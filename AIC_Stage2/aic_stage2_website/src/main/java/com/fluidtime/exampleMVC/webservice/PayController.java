package com.fluidtime.exampleMVC.webservice;

import java.util.LinkedList;
import java.util.List;

import com.fluidtime.exampleMVC.model.Bill;
import com.fluidtime.exampleMVC.model.PayBill;
import com.fluidtime.exampleMVC.model.User;

import org.eclipse.bpel.sample.BillingPortType;
import org.eclipse.bpel.sample.BillingRequest;
import org.eclipse.bpel.sample.BillingResponse;
import org.eclipse.bpel.sample.BillingService;
import org.eclipse.bpel.sample.GetBillDetails;
import org.eclipse.bpel.sample.GetBillDetailsRequest;
import org.eclipse.bpel.sample.GetBillDetailsResponse;
import org.eclipse.bpel.sample.GetBillDetailsService;
import org.eclipse.bpel.sample.GetBillList;
import org.eclipse.bpel.sample.GetBillListRequest;
import org.eclipse.bpel.sample.GetBillListResponse;
import org.eclipse.bpel.sample.GetBillListService;
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
        
        BillingService bs = new BillingService();
        BillingPortType billingPort = bs.getBillingPort();
        
        BillingRequest req = new BillingRequest();
        req.setInput("max");
        BillingResponse res = billingPort.initiate(req);
        
        paybill.setAmount(res.getAmount());
        paybill.setBillCount(res.getBillCount());
        paybill.setResult(res.getResult());
        
        return "Pay";
    }
}
