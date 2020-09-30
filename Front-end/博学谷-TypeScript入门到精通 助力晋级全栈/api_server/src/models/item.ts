//  商品模型
const rows = [
    {
        id: 1,
        name: "荣耀9X",
        desc: "荣耀9X 麒麟810 4000mAh超强续航 4800万超清夜拍 6.59英寸升降全面屏 全网通",
        unit: "台",
        unit_price: 139900,
        pic: "/images/664ee760a047d30b.jpg"
    },
    {
        id: 2,
        name: "荣耀MagicBook",
        desc: "荣耀MagicBook 2019 第三方Linux版 14英寸轻薄窄边框笔记本电脑（AMD锐龙5 3500U 8G 512G FHD IPS ）冰河银",
        unit: "台",
        unit_price: 399900,
        pic: "/images/758327e466cf4886.jpg"
    },
    {
        id: 3,
        name: "戴尔(DELL)成就3470",
        desc: "戴尔(DELL)成就3470 英特尔酷睿i3 商用办公 台式电脑整机(九代i3-9100 8G 1T 四年上门 键鼠 WIFI)21.5英寸",
        unit: "台",
        unit_price: 269900,
        pic: "/images/664ee760a047d30b.jpg"
    },
    {
        id: 4,
        name: "戴尔DELL游匣G3",
        desc: "戴尔DELL游匣G3 15.6英寸英特尔酷睿i7游戏笔记本电脑(i7-9750H 8G 512G GTX1660TiMQ 6G 2年整机上门)",
        unit: "台",
        unit_price: 729900,
        pic: "/images/3d45d4e8dd86c948.jpg"
    },
    {
        id: 5,
        name: "微软（Microsoft）Surface Go",
        desc: "微软（Microsoft）Surface Go 二合一平板电脑 10英寸（英特尔 奔腾 金牌处理器4415Y 4G内存 64G存储）",
        unit: "台",
        unit_price: 258800,
        pic: "/images/60b8d85317e351b9.jpg"
    },
    {
        id: 6,
        name: "Apple iPad 平板电脑 9.7英寸（128G WLAN版）",
        desc: "【Pencil套装版】Apple iPad 平板电脑 9.7英寸（128G WLAN版）金色及Pencil套装 MRJP2CH/A",
        unit: "台",
        unit_price: 354800,
        pic: "/images/3e64e84f28efa5f8.jpg"
    },
    {
        id: 7,
        name: "华为平板M6",
        desc: "华为平板 M6 10.8英寸麒麟980影音娱乐平板电脑4GB+128GB WiFi（银钻灰）",
        unit: "台",
        unit_price: 264900,
        pic: "/images/da2e35706857d55d.jpg"
    },
    {
        id: 8,
        name: "惠普（HP） M329dn激光多功能一体机",
        desc: "惠普（HP） M329dn激光多功能一体机 商务办公三合一 打印复印扫描 自动双面打印 M427系列升级型号",
        unit: "台",
        unit_price: 369900,
        pic: "/images/022c739b8920111d.jpg"
    },
    {
        id: 9,
        name: "TCL 55T680AI人工智能液晶电视机",
        desc: "TCL 55T680 55英寸 8米AI声控 MEMC防抖 4K超高清超薄全面屏 智慧屏 全场景AI人工智能液晶电视机",
        unit: "台",
        unit_price: 298800,
        pic: "/images/f83710b2b437156f.jpg"
    },
    {
        id: 10,
        name: "小米电视4S液晶平板电视",
        desc: "小米电视4S 75英寸 4K超高清 HDR 蓝牙语音遥控 2GB+8GB 人工智能语音网络液晶平板电视L75M5-4S",
        unit: "台",
        unit_price: 459900,
        pic: "/images/5bfcef81N8cc6b35d.jpg"
    }
];

class Item {
    static data = rows;
    static getList() {
        return this.data;
    }
}

export =Item; 