package com.wong.Example_00013;

import junit.framework.TestCase;

public class RomanToIntegerTest extends TestCase {
    private RomanToInteger instance;
    
    public void setUp() throws Exception {
        instance = new RomanToInteger();
        super.setUp();
    }
    
    public void testRomanToInt() {
        System.out.println(instance.romanToInt("III"));
    }
}