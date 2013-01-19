
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


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

    private final static QName _ValidateLoginUsername_QNAME = new QName("http://tempuri.org/", "username");
    private final static QName _ValidateLoginPassword_QNAME = new QName("http://tempuri.org/", "password");
    private final static QName _GetCompanyFromUsernameResponseGetCompanyFromUsernameResult_QNAME = new QName("http://tempuri.org/", "getCompanyFromUsernameResult");
    private final static QName _RegisterCompany_QNAME = new QName("http://tempuri.org/", "company");
    private final static QName _RegisterEmail_QNAME = new QName("http://tempuri.org/", "email");
    private final static QName _RegisterFirstname_QNAME = new QName("http://tempuri.org/", "firstname");
    private final static QName _RegisterCreditcard_QNAME = new QName("http://tempuri.org/", "creditcard");
    private final static QName _RegisterLastname_QNAME = new QName("http://tempuri.org/", "lastname");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link Register }
     * 
     */
    public Register createRegister() {
        return new Register();
    }

    /**
     * Create an instance of {@link GetCompanyFromUsernameResponse }
     * 
     */
    public GetCompanyFromUsernameResponse createGetCompanyFromUsernameResponse() {
        return new GetCompanyFromUsernameResponse();
    }

    /**
     * Create an instance of {@link GetCompanyFromUsername }
     * 
     */
    public GetCompanyFromUsername createGetCompanyFromUsername() {
        return new GetCompanyFromUsername();
    }

    /**
     * Create an instance of {@link IsLoggedInResponse }
     * 
     */
    public IsLoggedInResponse createIsLoggedInResponse() {
        return new IsLoggedInResponse();
    }

    /**
     * Create an instance of {@link UnregisterResponse }
     * 
     */
    public UnregisterResponse createUnregisterResponse() {
        return new UnregisterResponse();
    }

    /**
     * Create an instance of {@link IsLoggedIn }
     * 
     */
    public IsLoggedIn createIsLoggedIn() {
        return new IsLoggedIn();
    }

    /**
     * Create an instance of {@link Unregister }
     * 
     */
    public Unregister createUnregister() {
        return new Unregister();
    }

    /**
     * Create an instance of {@link ValidateLogin }
     * 
     */
    public ValidateLogin createValidateLogin() {
        return new ValidateLogin();
    }

    /**
     * Create an instance of {@link RegisterResponse }
     * 
     */
    public RegisterResponse createRegisterResponse() {
        return new RegisterResponse();
    }

    /**
     * Create an instance of {@link ValidateLoginResponse }
     * 
     */
    public ValidateLoginResponse createValidateLoginResponse() {
        return new ValidateLoginResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = ValidateLogin.class)
    public JAXBElement<String> createValidateLoginUsername(String value) {
        return new JAXBElement<String>(_ValidateLoginUsername_QNAME, String.class, ValidateLogin.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "password", scope = ValidateLogin.class)
    public JAXBElement<String> createValidateLoginPassword(String value) {
        return new JAXBElement<String>(_ValidateLoginPassword_QNAME, String.class, ValidateLogin.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "getCompanyFromUsernameResult", scope = GetCompanyFromUsernameResponse.class)
    public JAXBElement<String> createGetCompanyFromUsernameResponseGetCompanyFromUsernameResult(String value) {
        return new JAXBElement<String>(_GetCompanyFromUsernameResponseGetCompanyFromUsernameResult_QNAME, String.class, GetCompanyFromUsernameResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "company", scope = Register.class)
    public JAXBElement<String> createRegisterCompany(String value) {
        return new JAXBElement<String>(_RegisterCompany_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "email", scope = Register.class)
    public JAXBElement<String> createRegisterEmail(String value) {
        return new JAXBElement<String>(_RegisterEmail_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = Register.class)
    public JAXBElement<String> createRegisterUsername(String value) {
        return new JAXBElement<String>(_ValidateLoginUsername_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "password", scope = Register.class)
    public JAXBElement<String> createRegisterPassword(String value) {
        return new JAXBElement<String>(_ValidateLoginPassword_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "firstname", scope = Register.class)
    public JAXBElement<String> createRegisterFirstname(String value) {
        return new JAXBElement<String>(_RegisterFirstname_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "creditcard", scope = Register.class)
    public JAXBElement<String> createRegisterCreditcard(String value) {
        return new JAXBElement<String>(_RegisterCreditcard_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "lastname", scope = Register.class)
    public JAXBElement<String> createRegisterLastname(String value) {
        return new JAXBElement<String>(_RegisterLastname_QNAME, String.class, Register.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = Unregister.class)
    public JAXBElement<String> createUnregisterUsername(String value) {
        return new JAXBElement<String>(_ValidateLoginUsername_QNAME, String.class, Unregister.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "username", scope = GetCompanyFromUsername.class)
    public JAXBElement<String> createGetCompanyFromUsernameUsername(String value) {
        return new JAXBElement<String>(_ValidateLoginUsername_QNAME, String.class, GetCompanyFromUsername.class, value);
    }

}
