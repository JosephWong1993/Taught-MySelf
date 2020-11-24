package com.wong.Example_00461;

/**
 * 461. 汉明距离
 */
public class HammingDistance {
    /**
     * 方法一：内置位计数功能
     */
    public int hammingDistance_1(int x, int y) {
        return Integer.bitCount(x ^ y);
    }
    
    /**
     * 方法二：移位
     */
    public int hammingDistance_2(int x, int y) {
        int xor = x ^ y;
        int distance = 0;
        while (xor != 0) {
            if ((xor & 1) == 1) {
                distance++;
            }
            xor = xor >> 1;
        }
        return distance;
    }
    
    /**
     * 方法三：布赖恩·克尼根算法
     */
    public int hammingDistance_3(int x, int y) {
        int xor = x ^ y;
        int distance = 0;
        while (xor != 0) {
            distance++;
            xor = xor & (xor - 1);
        }
        return distance;
    }
}