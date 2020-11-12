package com.wong.Test;

import com.wong.web.Servlet;
import org.junit.Test;

public class MainTest {
    @Test
    public void test() {
        new Servlet().doGet();
    }
}
