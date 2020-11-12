package com.wong.utils;

import com.wong.service.UserService;

import java.util.ResourceBundle;

public class BeanFactory {
    /**
     * 读取配置文件，创建实现类对象返回
     * 方法：传递接口，根据接口名读取键值对
     * 创建出接口实现类对象
     * <p>
     * 参数是一个接口的class对象
     * <p>
     * UserService=com.wong.service.impl.UserServiceImpl
     */
    public static <T> T getInstance(Class<T> clazz) {
        T obj = null;
        try {
            // 获取到接口名
            String simpleName = clazz.getSimpleName();
//            System.out.println(simpleName);

            ResourceBundle bundle = ResourceBundle.getBundle("bean");
            // 接口名作为键
            String className = bundle.getString(simpleName);
//            System.out.println(className);
            // 反射创建对象
            obj = (T) Class.forName(className).newInstance();
        } catch (Exception e) {
            e.printStackTrace();
        }
        return obj;
    }
}
