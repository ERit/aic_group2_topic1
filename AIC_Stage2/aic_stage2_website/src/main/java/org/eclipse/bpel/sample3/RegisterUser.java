
package org.eclipse.bpel.sample3;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.logging.Logger;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.1.6 in JDK 6
 * Generated source version: 2.1
 * 
 */
@WebServiceClient(name = "registerUser", targetNamespace = "http://eclipse.org/bpel/sample3", wsdlLocation = "http://localhost:8080/ode/processes/registerUser?wsdl")
public class RegisterUser
    extends Service
{

    private final static URL REGISTERUSER_WSDL_LOCATION;
    private final static Logger logger = Logger.getLogger(org.eclipse.bpel.sample3.RegisterUser.class.getName());

    static {
        URL url = null;
        try {
            URL baseUrl;
            baseUrl = org.eclipse.bpel.sample3.RegisterUser.class.getResource(".");
            url = new URL(baseUrl, "http://localhost:8080/ode/processes/registerUser?wsdl");
        } catch (MalformedURLException e) {
            logger.warning("Failed to create URL for the wsdl Location: 'http://localhost:8080/ode/processes/registerUser?wsdl', retrying as a local file");
            logger.warning(e.getMessage());
        }
        REGISTERUSER_WSDL_LOCATION = url;
    }

    public RegisterUser(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public RegisterUser() {
        super(REGISTERUSER_WSDL_LOCATION, new QName("http://eclipse.org/bpel/sample3", "registerUser"));
    }

    /**
     * 
     * @return
     *     returns RegisterUserPortType
     */
    @WebEndpoint(name = "registerUserSOAP11port_http")
    public RegisterUserPortType getRegisterUserSOAP11PortHttp() {
        return super.getPort(new QName("http://eclipse.org/bpel/sample3", "registerUserSOAP11port_http"), RegisterUserPortType.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns RegisterUserPortType
     */
    @WebEndpoint(name = "registerUserSOAP11port_http")
    public RegisterUserPortType getRegisterUserSOAP11PortHttp(WebServiceFeature... features) {
        return super.getPort(new QName("http://eclipse.org/bpel/sample3", "registerUserSOAP11port_http"), RegisterUserPortType.class, features);
    }

}
