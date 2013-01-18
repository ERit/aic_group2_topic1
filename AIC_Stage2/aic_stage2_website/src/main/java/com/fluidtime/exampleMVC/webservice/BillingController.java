package com.fluidtime.exampleMVC.webservice;

import java.util.LinkedList;
import java.util.List;

import com.fluidtime.exampleMVC.model.Bill;
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
public class BillingController {

    HttpSession session;

    @RequestMapping(value = "/Billing", method = RequestMethod.GET)
    public String overview(HttpServletRequest request, Model model) {

        session = request.getSession();
        User user = (User) session.getAttribute("user");

        if (user == null)
            return "Index";


        model.addAttribute("user", user);
        // TODO: Get billing from logged in "user"
        
        GetBillListService getBillingListService = new GetBillListService();
        GetBillList bl = getBillingListService.getGetBillListPort();
        
        GetBillListRequest payload = new GetBillListRequest();
        payload.setInput(user.getName());
        GetBillListResponse response = bl.process(payload);
                
        String billIds = "ids: " + response.getResult();
        billIds.trim();
        String[] ids = billIds.split(" ");
        String idsConCat = "id list: ";
        List<Integer> idArray = new LinkedList<Integer>();
        for (String i : ids) {
        	try {
        		int newid = Integer.parseInt(i);
        		idArray.add(newid);
        		idsConCat += i + ", ";
        	} catch(NumberFormatException e) {
        		continue;
        	}
        }

        
        
        GetBillDetailsService bdsService = new GetBillDetailsService();
        GetBillDetails details = bdsService.getGetBillDetailsPort();

        List<Bill> bills = new LinkedList<Bill>();
        for (Integer curId : idArray) {
	        
	        GetBillDetailsRequest detailsPayload = new GetBillDetailsRequest();
	        detailsPayload.setInput(curId);
	        GetBillDetailsResponse detailsResponse = details.process(detailsPayload);
	        
	        Bill bill = new Bill();
	        bill.setAmount(detailsResponse.getAmount());
	        bill.setCustomerId(detailsResponse.getCustomerId());
	        bill.setCustomerUsername(detailsResponse.getCustromerUsername());
	        bill.setId(detailsResponse.getId());
	        bill.setPayed(detailsResponse.isIsPayed());
	        bills.add(bill);
        }
        
        model.addAttribute("bills", bills);
        
        return "Billing";
    }
}
