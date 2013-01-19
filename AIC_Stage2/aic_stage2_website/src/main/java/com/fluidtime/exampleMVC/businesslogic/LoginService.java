package com.fluidtime.exampleMVC.businesslogic;


import com.fluidtime.exampleMVC.exception.LoginFailedException;
import com.fluidtime.exampleMVC.model.User;
import com.fluidtime.exampleMVC.utils.ServiceReader;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.io.IOException;

@Component
public class LoginService {

    @Autowired
    ServiceReader serviceReader;

    public boolean login(String username, String password) throws LoginFailedException, IOException {


        return getLoginFromBPELService(username, password);
    }

    public boolean getLoginFromBPELService(String username, String password) throws LoginFailedException, IOException {

        boolean loginOk = false;

        try {
            loginOk = serviceReader.loginFromBPELService(username, password);
        } catch (Exception e) {

            throw new IOException(e);
        } 

        return loginOk;
    }

    public boolean registerUser(User user) throws Exception {

        return serviceReader.registerFromBPELService(user);
    }
}
