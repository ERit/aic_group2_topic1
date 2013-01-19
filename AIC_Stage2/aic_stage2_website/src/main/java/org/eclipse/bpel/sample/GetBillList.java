
package org.eclipse.bpel.sample;

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
@WebServiceClient(name = "getBillList", targetNamespace = "http://eclipse.org/bpel/sample", wsdlLocation = "http://localhost:8080/ode/processes/getBillList?wsdl")
public class GetBillList
    extends Service
{

    private final static URL GETBILLLIST_WSDL_LOCATION;
    private final static Logger logger = Logger.getLogger(org.eclipse.bpel.sample.GetBillList.class.getName());

    static {
        URL url = null;
        try {
            URL baseUrl;
            baseUrl = org.eclipse.bpel.sample.GetBillList.class.getResource(".");
            url = new URL(baseUrl, "http://localhost:8080/ode/processes/getBillList?wsdl");
        } catch (MalformedURLException e) {
            logger.warning("Failed to create URL for the wsdl Location: 'http://localhost:8080/ode/processes/getBillList?wsdl', retrying as a local file");
            logger.warning(e.getMessage());
        }
        GETBILLLIST_WSDL_LOCATION = url;
    }

    public GetBillList(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public GetBillList() {
        super(GETBILLLIST_WSDL_LOCATION, new QName("http://eclipse.org/bpel/sample", "getBillList"));
    }

    /**
     * 
     * @return
     *     returns GetBillListPortType
     */
    @WebEndpoint(name = "getBillListSOAP11port_http")
    public GetBillListPortType getGetBillListSOAP11PortHttp() {
        return super.getPort(new QName("http://eclipse.org/bpel/sample", "getBillListSOAP11port_http"), GetBillListPortType.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns GetBillListPortType
     */
    @WebEndpoint(name = "getBillListSOAP11port_http")
    public GetBillListPortType getGetBillListSOAP11PortHttp(WebServiceFeature... features) {
        return super.getPort(new QName("http://eclipse.org/bpel/sample", "getBillListSOAP11port_http"), GetBillListPortType.class, features);
    }

}
