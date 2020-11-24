package com.wong.Example_00013;

import java.util.HashMap;

/**
 * 13. 罗马数字转整数
 */
public class RomanToInteger {
    public int romanToInt(String s) {
        HashMap<String, Integer> map = new HashMap<String, Integer>();
        map.put("I", 1);
        map.put("V", 5);
        map.put("X", 10);
        map.put("L", 50);
        map.put("C", 100);
        map.put("D", 500);
        map.put("M", 1000);
        map.put("IV", 4);
        map.put("IX", 9);
        map.put("XL", 40);
        map.put("XC", 90);
        map.put("CD", 400);
        map.put("CM", 900);
        
        Integer ans = 0;
        Integer index = 0;
        Integer length = s.length();
        while (index < length) {
            String str;
            if (index < length - 1) {
                str = s.substring(index, index + 2);
                if (map.containsKey(str)) {
                    ans += map.get(str);
                    index += 2;
                    continue;
                }
            }
            str = s.substring(index, index + 1);
            ans += map.get(str);
            index += 1;
        }
        return ans;
    }
}