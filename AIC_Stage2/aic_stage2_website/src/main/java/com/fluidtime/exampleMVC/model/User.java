package com.fluidtime.exampleMVC.model;


public class User {

    private String name;
    private String password;
    private String email;
    private String ccnumber;
    private String value = "";
    private String firstname = "";
	private String lastname = "";

	private String company;
    
	
    public String getLastname() {
		return lastname;
	}

	public void setLastname(String lastname) {
		this.lastname = lastname;
	}
    
    public String getFirstname() {
		return firstname;
	}

	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}

    public String getCompany() {
        return company;
    }

    public void setCompany(String company) {
        this.company = company;
    }

    public String getCcnumber() {
        return ccnumber;
    }

    public void setCcnumber(String ccnumber) {
        this.ccnumber = ccnumber;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getName() {

        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    
    
    public String getStatisticValue() {
        return value;
    }

    public void setStatisticValue(String value) {
        this.value = value;
    }

    @Override
    public String toString() {
        return "User{" +
                "name='" + name + '\'' +
                ", password='" + password + '\'' +
                ", email='" + email + '\'' +
                ", ccnumber='" + ccnumber + '\'' +
                ", company='" + company + '\'' +
                '}';
    }
}
