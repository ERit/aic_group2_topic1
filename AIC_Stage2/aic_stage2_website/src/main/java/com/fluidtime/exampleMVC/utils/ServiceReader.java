package com.fluidtime.exampleMVC.utils;

import com.fluidtime.exampleMVC.model.User;
import com.fluidtime.exampleMVC.model.xml.UserXml;
import org.dozer.DozerBeanMapperSingletonWrapper;
import org.dozer.Mapper;
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

    public User registerFromBPELService(User user) throws Exception {

        URL url;
        URLConnection connection;

        String urlString = "http://localhost:8080/bpelServiceRegister?username=" + user.getName() + "&password=" + user.getPassword() +
                "&email= " + user.getEmail() + "&ccnumber=" + user.getCcnumber() + "&company=" + user.getCompany();

        url = new URL(urlString);
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
    
    public double getSentimentAnalysisFromBPELService() throws Exception {
    	/*String endpoint = "http://localhost:8080/ode/processes/Caller";
		Service  service = new Service();
		Call call = (Call) service.createCall();
		  
		call.setTargetEndpointAddress( new java.net.URL(endpoint) );
		call.setOperationName(new QName("http://soapinterop.org/", "echoString"));
	
		String ret = (String) call.invoke( new Object[] { "Hello!" } );
		System.out.println("Sent 'Hello!', got '" + ret + "'");*/
    	
    	return 0.0;
    	
    }
}
