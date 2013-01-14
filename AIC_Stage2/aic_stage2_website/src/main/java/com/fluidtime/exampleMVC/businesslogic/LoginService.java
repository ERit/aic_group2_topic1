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

    public User login(String username, String password) throws LoginFailedException, IOException {


        return getLoginFromBPELService(username, password);
    }

    public User getLoginFromBPELService(String username, String password) throws LoginFailedException, IOException {

        User user = null;

       /* try {
            user = serviceReader.loginFromBPELService(username, password);
        } catch (Exception e) {

            throw new IOException(e);
        }  */


        //TODO
        user = new User();

        user.setName(username);
        user.setEmail("admin@admin.at");
        user.setCcnumber("1282834784748478343");
        user.setPassword(password);
        user.setCompany("Microsoft");

        return user;
    }

    public boolean registerUser(User user) throws Exception {

        //return serviceReader.registerFromBPELService(user);

        return true;
    }
}
