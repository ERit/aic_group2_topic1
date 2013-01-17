
package org.eclipse.bpel.sample;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.eclipse.bpel.sample package. 
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

    private final static QName _SimpleStringType_QNAME = new QName("http://eclipse.org/bpel/sample", "simpleStringType");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.eclipse.bpel.sample
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetBillListRequest }
     * 
     */
    public GetBillListRequest createGetBillListRequest() {
        return new GetBillListRequest();
    }

    /**
     * Create an instance of {@link GetBillListResponse }
     * 
     */
    public GetBillListResponse createGetBillListResponse() {
        return new GetBillListResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://eclipse.org/bpel/sample", name = "simpleStringType")
    public JAXBElement<String> createSimpleStringType(String value) {
        return new JAXBElement<String>(_SimpleStringType_QNAME, String.class, null, value);
    }

}
