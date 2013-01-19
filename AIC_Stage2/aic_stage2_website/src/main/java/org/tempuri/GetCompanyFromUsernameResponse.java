
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="getCompanyFromUsernameResult" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "getCompanyFromUsernameResult"
})
@XmlRootElement(name = "getCompanyFromUsernameResponse")
public class GetCompanyFromUsernameResponse {

    @XmlElementRef(name = "getCompanyFromUsernameResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> getCompanyFromUsernameResult;

    /**
     * Gets the value of the getCompanyFromUsernameResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getGetCompanyFromUsernameResult() {
        return getCompanyFromUsernameResult;
    }

    /**
     * Sets the value of the getCompanyFromUsernameResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setGetCompanyFromUsernameResult(JAXBElement<String> value) {
        this.getCompanyFromUsernameResult = value;
    }

}
