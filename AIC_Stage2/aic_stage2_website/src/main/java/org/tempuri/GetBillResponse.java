
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import org.datacontract.schemas._2004._07.billingservice.BillDetails;


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
 *         &lt;element name="GetBillResult" type="{http://schemas.datacontract.org/2004/07/BillingService}BillDetails" minOccurs="0"/>
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
    "getBillResult"
})
@XmlRootElement(name = "GetBillResponse")
public class GetBillResponse {

    @XmlElementRef(name = "GetBillResult", namespace = "http://tempuri.org/", type = JAXBElement.class)
    protected JAXBElement<BillDetails> getBillResult;

    /**
     * Gets the value of the getBillResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link BillDetails }{@code >}
     *     
     */
    public JAXBElement<BillDetails> getGetBillResult() {
        return getBillResult;
    }

    /**
     * Sets the value of the getBillResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link BillDetails }{@code >}
     *     
     */
    public void setGetBillResult(JAXBElement<BillDetails> value) {
        this.getBillResult = ((JAXBElement<BillDetails> ) value);
    }

}
