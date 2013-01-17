
package org.eclipse.bpel.sample;

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
@WebServiceClient(name = "billingService", targetNamespace = "http://eclipse.org/bpel/sample", wsdlLocation = "file:/home/bernhard/Projects/Uni/bill2/bpelContent/billingArtifacts.wsdl")
public class BillingService
    extends Service
{

    private final static URL BILLINGSERVICE_WSDL_LOCATION;
    private final static WebServiceException BILLINGSERVICE_EXCEPTION;
    private final static QName BILLINGSERVICE_QNAME = new QName("http://eclipse.org/bpel/sample", "billingService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("file:/home/bernhard/Projects/Uni/bill2/bpelContent/billingArtifacts.wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        BILLINGSERVICE_WSDL_LOCATION = url;
        BILLINGSERVICE_EXCEPTION = e;
    }

    public BillingService() {
        super(__getWsdlLocation(), BILLINGSERVICE_QNAME);
    }

    public BillingService(WebServiceFeature... features) {
        super(__getWsdlLocation(), BILLINGSERVICE_QNAME, features);
    }

    public BillingService(URL wsdlLocation) {
        super(wsdlLocation, BILLINGSERVICE_QNAME);
    }

    public BillingService(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, BILLINGSERVICE_QNAME, features);
    }

    public BillingService(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public BillingService(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns BillingPortType
     */
    @WebEndpoint(name = "billingPort")
    public BillingPortType getBillingPort() {
        return super.getPort(new QName("http://eclipse.org/bpel/sample", "billingPort"), BillingPortType.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns BillingPortType
     */
    @WebEndpoint(name = "billingPort")
    public BillingPortType getBillingPort(WebServiceFeature... features) {
        return super.getPort(new QName("http://eclipse.org/bpel/sample", "billingPort"), BillingPortType.class, features);
    }

    private static URL __getWsdlLocation() {
        if (BILLINGSERVICE_EXCEPTION!= null) {
            throw BILLINGSERVICE_EXCEPTION;
        }
        return BILLINGSERVICE_WSDL_LOCATION;
    }

}
