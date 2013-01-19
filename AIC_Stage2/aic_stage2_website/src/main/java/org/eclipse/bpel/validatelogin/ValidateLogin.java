
package org.eclipse.bpel.validatelogin;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.4-b01
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "validateLogin", targetNamespace = "http://eclipse.org/bpel/validateLogin", wsdlLocation = "http://localhost:8080/ode/processes/validateLogin?wsdl")
public class ValidateLogin
    extends Service
{

    private final static URL VALIDATELOGIN_WSDL_LOCATION;
    private final static WebServiceException VALIDATELOGIN_EXCEPTION;
    private final static QName VALIDATELOGIN_QNAME = new QName("http://eclipse.org/bpel/validateLogin", "validateLogin");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:8080/ode/processes/validateLogin?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        VALIDATELOGIN_WSDL_LOCATION = url;
        VALIDATELOGIN_EXCEPTION = e;
    }

    public ValidateLogin() {
        super(__getWsdlLocation(), VALIDATELOGIN_QNAME);
    }

    public ValidateLogin(WebServiceFeature... features) {
        super(__getWsdlLocation(), VALIDATELOGIN_QNAME, features);
    }

    public ValidateLogin(URL wsdlLocation) {
        super(wsdlLocation, VALIDATELOGIN_QNAME);
    }

    public ValidateLogin(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, VALIDATELOGIN_QNAME, features);
    }

    public ValidateLogin(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public ValidateLogin(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns ValidateLoginPortType
     */
    @WebEndpoint(name = "validateLoginSOAP11port_http")
    public ValidateLoginPortType getValidateLoginSOAP11PortHttp() {
        return super.getPort(new QName("http://eclipse.org/bpel/validateLogin", "validateLoginSOAP11port_http"), ValidateLoginPortType.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns ValidateLoginPortType
     */
    @WebEndpoint(name = "validateLoginSOAP11port_http")
    public ValidateLoginPortType getValidateLoginSOAP11PortHttp(WebServiceFeature... features) {
        return super.getPort(new QName("http://eclipse.org/bpel/validateLogin", "validateLoginSOAP11port_http"), ValidateLoginPortType.class, features);
    }

    private static URL __getWsdlLocation() {
        if (VALIDATELOGIN_EXCEPTION!= null) {
            throw VALIDATELOGIN_EXCEPTION;
        }
        return VALIDATELOGIN_WSDL_LOCATION;
    }

}