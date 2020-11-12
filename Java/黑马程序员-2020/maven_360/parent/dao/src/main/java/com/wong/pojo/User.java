package com.wong.pojo;

import lombok.Data;

@Data
public class User {
    private String id;
    private String username;
    private String password;
    private String phone;
    private String address;
    private double money;
}
