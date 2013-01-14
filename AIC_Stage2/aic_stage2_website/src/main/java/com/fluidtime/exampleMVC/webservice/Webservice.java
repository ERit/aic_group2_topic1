package com.fluidtime.exampleMVC.webservice;

import com.fluidtime.exampleMVC.model.User;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

@Controller
@RequestMapping(value = "")
public class Webservice {

    HttpSession session;

    @RequestMapping(value = "/", method = RequestMethod.GET)
    public String index(Model model) {

        model.addAttribute("fromIndex", true);

        return "Index";
    }

    @RequestMapping(value = "/Overview", method = RequestMethod.GET)
    public String overview(HttpServletRequest request, Model model) {

        session = request.getSession();
        User user = (User) session.getAttribute("user");

        if(user == null)
            return "Index";

        model.addAttribute("user", user);

        return "Overview";
    }
}
