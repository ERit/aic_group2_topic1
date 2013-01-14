package com.fluidtime.exampleMVC.exception;


public class LoginFailedException extends Exception {
    public LoginFailedException(String message) {
        super(message);
    }
}