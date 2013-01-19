package com.fluidtime.exampleMVC.webservice;

import com.fluidtime.exampleMVC.model.PayBill;
import com.fluidtime.exampleMVC.model.User;
import org.eclipse.bpel.sample.Billing;
import org.eclipse.bpel.sample.BillingPortType;
import org.eclipse.bpel.sample.BillingRequest;
import org.eclipse.bpel.sample.BillingResponse;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;


@Controller
@RequestMapping(value = "")
public class PayController {

    HttpSession session;

    @RequestMapping(value = "/Pay", method = RequestMethod.GET)
    public String overview(HttpServletRequest request, Model model) {

        session = request.getSession();
        User user = (User) session.getAttribute("user");

        if (user == null)
            return "Index";
        
        PayBill paybill = new PayBill();


        model.addAttribute("user", user);
        model.addAttribute("payBill", paybill);
        
        
        Billing billing = new Billing();
   	 
		BillingPortType t = billing.getPort(BillingPortType.class);
		BillingRequest brequest = new BillingRequest();
		brequest.setInput(user.getName());
		BillingResponse response = t.initiate(brequest);
        
        paybill.setAmount(response.getAmount());
        paybill.setBillCount(response.getBillCount());
        paybill.setResult(response.getResult());
        
        return "Pay";
    }
}
