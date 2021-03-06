# Project planning

## Foreword
Nowadays it’s impossible to imagine an organization without an Enterprise Resource Planning system, later written as ERP. As many organizations are modernizing their business, for example due to the automation of processes, adding new techniques to their processes, adding artificial intelligence to predict and many ideas more. The ERP systems as we know them today are likely to become a reliability in such modern organizations, by cause of the rigidity they come with. In fact the system tend to lose functionality and doesn’t meet the business requirements to it's full potential anymore. 

Managerize focuses on small organizations to meet their requirements by a set of predefined settings, including the ability to add new features quickly as a service in any possible programming language. Also Managerize is a package consistent of separate small autonomous services, thus capable to be modificated/extented to any particular organization.

## Contents
1. [Definition][1]
1. [Objectives & Criteria][2]
2. [Size][3]
3. [Organization][4]
4. [Limits & Risks][5]
5. [Stakeholders][6]
6. [Project checks][7] 

[1]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#1-project-definition
[2]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#2-project-objectives-and-success-criteria
[3]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#3-project-size
[4]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#4-organization
[5]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#5-limits--tasks
[6]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#6-stakeholders
[7]: https://github.com/SalomeCodes/Managerize/blob/master/documentation/project-initiation-document.md#7-project-checks

## 1. Project definition
Facilitation to track business processes through an integrated software system is the main objective for Managerize. This integrated view of company data should enhance information sharing and collaboration across functional and corporate boundaries. For Managerize there are five main segments that most likely improve the organization; namely efficiency, cost reduction, quality, profitability and decentralization. 

A set of small services represent Managerize as a whole. Each service, used as a building block, come with a different set of bounded requirements. All services can operate like an individual or combined together. 

The services consistent in Managerize are Factura, Klantify, Afspraakification and Offerution.
Managerize is the shell of all these side services, through domain driven design all these services can be used autonomously. The description of each task will be summarized in short within the list below:  
* Factura
    * Create invoices
    * See invoices
    * Register payments
    * Generate PDF invoices
    * Create customers
    * See customers
    * Create items
    * See items
* Klantify
    * Create customers
    * See customers
    * Track customer contact moments
* Afspraakification
    * Customers create an appointment
    * Calendar
    * Overview of appointments
* Offerution
    * Customers create offers
    * Generate PDF offers 

## 2. Project objectives and success criteria
### 2.1 Outputs
* A well defined architecture
* Multiple autonomous services
* Services in different kind of programming languages
    * C#
    * Java
    * Python
* Well described documentation
* Tests written 
    * 80% coverage
    * 80% mutation coverage
* Continious Integration & Delivery pipeline
    * Docker
    * Kubernetes
    * Jenkins
* Planning tool 
    * Trello

### 2.2 Outcomes
* Financial support 
    * Invoice generator
    * Management dashboard
* Sales support
    * Offer generator
* Customer support
    * Customer dashboard 
    * Overview of invoices
* Inventory support
    * Inventory dashboard
* Business predictions are nice to have
    * Financial predictions
    * Chure predictions

## 3. Limits & Tasks
If Managerize is integrated within the organization it's not possible to combine two services that have been used separately, although the setup to combine the services is pretty easy with environment variables. 

## 4. Stakeholders


## 5. Project checks
Tests run automatically through the Jenkins pipeline before releasing to the server. 
