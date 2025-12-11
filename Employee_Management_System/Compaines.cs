namespace Employee_Management_System;

internal class Compaines(int numberOfCompanies)
{
    private Company[] Companies = new Company[numberOfCompanies];
    
    public Company GetCompany(int companyId)
    {
        return Companies[companyId];
    }

    public void AddCompany(Company company)
    {
        Companies[company.Id] = company;
    }
}