import { createApp } from './app'

export default context => {
  return new Promise(async (resolve, reject) => {
    const { app, router, store } = await createApp(context)
    //  设置当前路由
    router.push(context.url)
    //  等待组件解决方案
    router.onReady(() => {
      const matchedComponents = router.getMatchedComponents()

      Promise.all(matchedComponents.map(Component => {
        if (Component.asyncData) {
          return Component.asyncData({
            store,
            route: router.currentRoute,
          })
        }
      }).then(() => {
        // 发回store的state
        context.state = store.state

        // 将应用发送给渲染器
        resolve(app)
      }).catch(reject))
    }, reject)
  })
}
