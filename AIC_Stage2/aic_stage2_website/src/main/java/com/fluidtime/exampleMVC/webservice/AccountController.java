package com.fluidtime.exampleMVC.webservice;

import com.fluidtime.exampleMVC.businesslogic.LoginService;
import com.fluidtime.exampleMVC.exception.LoginFailedException;
import com.fluidtime.exampleMVC.model.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;
import java.io.IOException;

@Controller
@RequestMapping(value = "")
public class AccountController {

    @Autowired
    LoginService loginService;
    HttpSession session;

    @RequestMapping(value = "/Login", method = RequestMethod.POST)
    public String login(Model model, HttpServletRequest request, @RequestParam(required = true) String username,
                        @RequestParam(required = true) String password) {

        User user = null;

        try {
            user = loginService.getLoginFromBPELService(username, password);
        } catch (LoginFailedException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        if (user != null) {

            session = request.getSession();
            session.setAttribute("user", user);

            model.addAttribute("user", user);

            return "Overview";
        } else {
            model.addAttribute("user", null);
            return "Login";
        }


    }

    @RequestMapping("/Logout")
    public String logout(HttpServletRequest request) {

        HttpSession session = request.getSession();
        session.invalidate();

        return "Index";
    }

    @RequestMapping(value = "/Register", method = RequestMethod.POST)
    public String register(HttpServletRequest request, Model model, @RequestParam(required = true) String username,
                           @RequestParam(required = true) String password1,
                           @RequestParam(required = true) String password2,
                           @RequestParam(required = true) String company,
                           @RequestParam(required = true) String ccnumber,
                           @RequestParam(required = true) String email) {

        if (!password1.equals(password2)) {

            model.addAttribute("registerText", "Password was not correct. Type again.");
            return "RegisterForm";

        }

        if (username.equals("") || password1.equals("") || password2.equals("") || company.equals("") || ccnumber.equals("") || email.equals("")) {

            model.addAttribute("registerText", "Please fill out all attributes.");
            return "RegisterForm";
        }

        User user = new User();
        user.setName(username);
        user.setPassword(password1);
        user.setCompany(company);
        user.setCcnumber(ccnumber);
        user.setEmail(email);

        try {
            if (loginService.registerUser(user)) {

                model.addAttribute("registerText", "You got registered successfully.");
                model.addAttribute("user", user);

                session = request.getSession();
                session.setAttribute("user", user);

                return "Overview";
            }
        } catch (Exception e) {
            model.addAttribute("registerText", "BPEL RegisterService not running.");
        }

        return "Index";
    }

    @RequestMapping("/RegisterForm")
    public String RegisterForm() {

        return "RegisterForm";
    }
}
