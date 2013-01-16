package com.fluidtime.exampleMVC.webservice;

import com.fluidtime.exampleMVC.model.User;
import com.fluidtime.exampleMVC.utils.ServiceReader;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

@Controller
@RequestMapping(value = "")
public class StatisticController {

    HttpSession session;
    ServiceReader serviceReader;

    @RequestMapping(value = "/Statistic", method = RequestMethod.GET)
    public String overview(HttpServletRequest request, Model model) {

        session = request.getSession();
        User user = (User) session.getAttribute("user");

        if (user == null)
            return "Index";

        model.addAttribute("user", user);

        // TODO: Get sentiment analysis from logged in "user"
        serviceReader = new ServiceReader();
        try {
			serviceReader.getSentimentAnalysisFromBPELService();
		} catch (Exception e) {
			e.printStackTrace();
		}

        return "Statistic";
    }
}
