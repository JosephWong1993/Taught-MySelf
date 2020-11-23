package com.wong.factory;

import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.Element;
import org.dom4j.io.SAXReader;

import java.io.InputStream;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * 作用：用于读取bean.xml文件，实现对象创建的工具类
 * <p>
 * 步骤：
 * 1.用于储存 接口名与实现对象的Map集合 Map<String,Object>
 * 2.解析beans.xml文件，实现把配置文件中的每一个Bean标签中的接口名与实现类对象，存储到Map集合中
 * 3.提供一个获取对象的方法，参数接收 接口名，从Map集合中查询对象，返回接口实现类对象
 */
public class BeanFactory {
    //1.用于储存 接口名与实现对象的Map集合 Map<String,Object>
    private static Map<String, Object> map = new HashMap<String, Object>();
    
    //2.解析beans.xml文件，实现把配置文件中的每一个Bean标签中的接口名与实现类对象，存储到Map集合中
    static {
        try {
            //加载beans.xml配置文件
            SAXReader saxReader = new SAXReader();
            InputStream inputStream = BeanFactory.class.getClassLoader().getResourceAsStream("beans.xml");
            Document document = saxReader.read(inputStream);
            //解析beans.xml配置文件
            Element beans = document.getRootElement();
            //获取beans的子标签
            List<Element> beanList = beans.elements();
            //遍历获取每一个bean标签
            for (Element bean : beanList) {
                //获取id，class属性的值
                String idValue = bean.attributeValue("id");
                String classValue = bean.attributeValue("class");
                //Bean标签中的接口名与实现类对象，存到Map集合中
                Object obj = Class.forName(classValue).newInstance();
                map.put(idValue, obj);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    public static Object getBean(String className) {
        return map.get(className);
    }
}
