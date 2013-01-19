
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;
import com.microsoft.schemas._2003._10.serialization.arrays.ArrayOfint;
import org.datacontract.schemas._2004._07.billingservice.BillDetails;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
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

    private final static QName _CalculateBillsForUserUsername_QNAME = new QName("http://tempuri.org/", "username");
    private final static QName _ListUsersBillsResponseListUsersBillsResult_QNAME = new QName("http://tempuri.org/", "ListUsersBillsResult");
    private final static QName _GetBillResponseGetBillResult_QNAME = new QName("http://tempuri.org/", "GetBillResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ListUsersBillsResponse }
     * 
     */
    public ListUsersBillsResponse createListUsersBillsResponse() {
        return new ListUsersBillsResponse();
    }

    /**
     * Create an instance of {@link GetBill }
     * 
     */
    public GetBill createGetBill() {
        return new GetBill();
    }

    /**
     * Create an instance of {@link CalculateBillsForUserResponse }
     * 
     */
    public CalculateBillsForUserResponse createCalculateBillsForUserResponse() {
        return new CalculateBillsForUserResponse();
    }

    /**
     * Create an instance of {@link ListUsersBills }
     * 
     */
    public ListUsersBills createListUsersBills() {
        return new ListUsersBills();
    }

    /**
     * Create an instance of {@link CalculateBillsForUser }
     * 
     */
    public CalculateBillsForUser createCalculateBillsForUser() {
        return new CalculateBillsForUser();
    }

    /**
     * Create an instance of {@link PayBill }
     * 
     */
    public PayBill createPayBill() {
        return new PayBill();
    }

    /**
     * Create an instance of {@link GetBillResponse }
     * 
     */
    public GetBillResponse createGetBillResponse() {
        return new GetBillResponse();
    }

    /**
     * Create an instance of {@link PayBillResponse }
     * 
     */
    public PayBillResponse createPayBillResponse() {
        return new PayBillResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = CalculateBillsForUser.class)
    public JAXBElement<String> createCalculateBillsForUserUsername(String value) {
        return new JAXBElement<String>(_CalculateBillsForUserUsername_QNAME, String.class, CalculateBillsForUser.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = ListUsersBills.class)
    public JAXBElement<String> createListUsersBillsUsername(String value) {
        return new JAXBElement<String>(_CalculateBillsForUserUsername_QNAME, String.class, ListUsersBills.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfint }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "ListUsersBillsResult", scope = ListUsersBillsResponse.class)
    public JAXBElement<ArrayOfint> createListUsersBillsResponseListUsersBillsResult(ArrayOfint value) {
        return new JAXBElement<ArrayOfint>(_ListUsersBillsResponseListUsersBillsResult_QNAME, ArrayOfint.class, ListUsersBillsResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BillDetails }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "GetBillResult", scope = GetBillResponse.class)
    public JAXBElement<BillDetails> createGetBillResponseGetBillResult(BillDetails value) {
        return new JAXBElement<BillDetails>(_GetBillResponseGetBillResult_QNAME, BillDetails.class, GetBillResponse.class, value);
    }

}
