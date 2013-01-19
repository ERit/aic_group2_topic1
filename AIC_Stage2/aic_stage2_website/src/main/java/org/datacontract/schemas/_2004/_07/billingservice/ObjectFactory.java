
package org.datacontract.schemas._2004._07.billingservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.datacontract.schemas._2004._07.billingservice package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _BillDetails_QNAME = new QName("http://schemas.datacontract.org/2004/07/BillingService", "BillDetails");
    private final static QName _BillDetailsCustomerUsername_QNAME = new QName("http://schemas.datacontract.org/2004/07/BillingService", "customerUsername");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.datacontract.schemas._2004._07.billingservice
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link BillDetails }
     * 
     */
    public BillDetails createBillDetails() {
        return new BillDetails();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BillDetails }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/BillingService", name = "BillDetails")
    public JAXBElement<BillDetails> createBillDetails(BillDetails value) {
        return new JAXBElement<BillDetails>(_BillDetails_QNAME, BillDetails.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/BillingService", name = "customerUsername", scope = BillDetails.class)
    public JAXBElement<String> createBillDetailsCustomerUsername(String value) {
        return new JAXBElement<String>(_BillDetailsCustomerUsername_QNAME, String.class, BillDetails.class, value);
    }

}
