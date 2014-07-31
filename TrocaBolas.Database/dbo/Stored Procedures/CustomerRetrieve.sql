CREATE PROCEDURE [dbo].[CustomerRetrieve]
	@startsWith AS VARCHAR(50)
AS
	SELECT Customer.CustomerId, 
		Customer.FirstName, 
		Customer.LastName,
		Customer.EmailAddress,
		Customer.CustomerTypeId
	FROM Customer
	WHERE LastName like @startsWith
RETURN 0
