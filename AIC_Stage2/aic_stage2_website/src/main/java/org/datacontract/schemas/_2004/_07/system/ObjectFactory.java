
package org.datacontract.schemas._2004._07.system;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.datacontract.schemas._2004._07.system package. 
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

    private final static QName _ArgumentException_QNAME = new QName("http://schemas.datacontract.org/2004/07/System", "ArgumentException");
    private final static QName _SystemException_QNAME = new QName("http://schemas.datacontract.org/2004/07/System", "SystemException");
    private final static QName _Exception_QNAME = new QName("http://schemas.datacontract.org/2004/07/System", "Exception");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.datacontract.schemas._2004._07.system
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ArgumentException }
     * 
     */
    public ArgumentException createArgumentException() {
        return new ArgumentException();
    }

    /**
     * Create an instance of {@link SystemException }
     * 
     */
    public SystemException createSystemException() {
        return new SystemException();
    }

    /**
     * Create an instance of {@link Exception }
     * 
     */
    public Exception createException() {
        return new Exception();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArgumentException }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/System", name = "ArgumentException")
    public JAXBElement<ArgumentException> createArgumentException(ArgumentException value) {
        return new JAXBElement<ArgumentException>(_ArgumentException_QNAME, ArgumentException.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SystemException }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/System", name = "SystemException")
    public JAXBElement<SystemException> createSystemException(SystemException value) {
        return new JAXBElement<SystemException>(_SystemException_QNAME, SystemException.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Exception }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/System", name = "Exception")
    public JAXBElement<Exception> createException(Exception value) {
        return new JAXBElement<Exception>(_Exception_QNAME, Exception.class, null, value);
    }

}
