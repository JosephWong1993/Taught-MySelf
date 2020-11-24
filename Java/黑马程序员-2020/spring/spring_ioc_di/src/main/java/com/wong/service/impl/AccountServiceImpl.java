package com.wong.service.impl;

import com.wong.service.AccountService;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Date;
import java.util.List;
import java.util.Map;
import java.util.Properties;
import java.util.Set;

/**
 * 业务接口实现类
 */
public class AccountServiceImpl implements AccountService {
    private String[] myStrs;
    
    private List<String> myList;
    
    private Set<String> mySet;
    
    private Map<String, String> myMap;
    
    private Properties myProps;
    
    public void setMyStrs(String[] myStrs) {
        this.myStrs = myStrs;
    }
    
    public void setMyList(List<String> myList) {
        this.myList = myList;
    }
    
    public void setMySet(Set<String> mySet) {
        this.mySet = mySet;
    }
    
    public void setMyMap(Map<String, String> myMap) {
        this.myMap = myMap;
    }
    
    public void setMyProps(Properties myProps) {
        this.myProps = myProps;
    }
    
    @Override
    public void save() {
        System.out.println("myStrs == " + Arrays.toString(myStrs));
        System.out.println("myList = " + myList);
        System.out.println("mySet = " + mySet);
        System.out.println("myMap = " + myMap);
        System.out.println("myProps = " + myProps);
    }
}
