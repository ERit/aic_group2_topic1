package com.fluidtime.exampleMVC.utils;

import com.fluidtime.exampleMVC.model.User;
import com.fluidtime.exampleMVC.model.xml.UserXml;
import com.fluidtime.exampleMVC.statistic_client.com.mytest.test.Caller;
import com.fluidtime.exampleMVC.statistic_client.com.mytest.test.CallerPortType;
import com.fluidtime.exampleMVC.statistic_client.com.mytest.test.CallerResponse;
import com.fluidtime.exampleMVC.statistic_client.com.mytest.test.CallerRequest;
import org.dozer.DozerBeanMapperSingletonWrapper;
import org.dozer.Mapper;
import org.eclipse.bpel.sample3.RegisterUser;
import org.eclipse.bpel.sample3.RegisterUserPortType;
import org.eclipse.bpel.sample3.RegisterUserRequest;
import org.eclipse.bpel.sample3.RegisterUserResponse;
import org.springframework.stereotype.Component;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import javax.xml.namespace.QName;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.StringReader;
import java.net.URL;
import java.net.URLConnection;

@Component
public class ServiceReader {

    public User loginFromBPELService(String username, String password) throws Exception {

        User user;
        URL url;
        URLConnection connection;

        url = new URL("http://localhost:8080/bpelServiceLogin?username=" + username + "&password=" + password);
        connection = url.openConnection();

        BufferedReader in = new BufferedReader(new InputStreamReader(connection.getInputStream()));
        String inputLine;
        String finalXmlString = new String();

        while ((inputLine = in.readLine()) != null)
            finalXmlString += inputLine;

        in.close();


        // parse user from xml file

        JAXBContext jaxbContext = JAXBContext.newInstance(UserXml.class);
        Unmarshaller unmarshaller = jaxbContext.createUnmarshaller();

        StringReader reader = new StringReader(finalXmlString);
        UserXml userxml = (UserXml) unmarshaller.unmarshal(reader);


        // Get mapping instance and convert
        Mapper mapper = DozerBeanMapperSingletonWrapper.getInstance();
        // Convert source to destination object
        user = mapper.map(userxml, User.class);


        return user;
    }

    public boolean registerFromBPELService(User user) throws Exception {
    	RegisterUser regUser = new RegisterUser();  	 
    	RegisterUserPortType rupt = regUser.getPort(RegisterUserPortType.class);
    	RegisterUserRequest request = new RegisterUserRequest();
    	
    	// name, pw, company, firstname, lastname, cc, email
		request.setUsername(user.getName());
		request.setPassword(user.getPassword());
		request.setCompany(user.getCompany());
		request.setFirstname(user.getFirstname());
		request.setLastname(user.getLastname());
		request.setCcnumber(user.getCcnumber());
		request.setEmail(user.getEmail());
						
		RegisterUserResponse regResponse = rupt.process(request);
				
		boolean regOk = false;
		
		try {
			Boolean.parseBoolean(regResponse.getResult());
		} catch (NumberFormatException nfe) {
			System.out.println(nfe);
		}
		
		return regOk;
    }
    
    public double getSentimentAnalysisFromBPELService(String username) throws Exception {
    	Caller caller = new Caller();
    	 
		CallerPortType t = caller.getPort(CallerPortType.class);
		CallerRequest request = new CallerRequest();
		request.setInput(username);
		CallerResponse response = t.process(request);
		
		double result = 0.5;
		
		try {
			result = Double.parseDouble(response.getResult());
		} catch (NumberFormatException nfe) {
			System.out.println(nfe);
		}
		   		
		return  result;
    }
    
    
    
    
}
