/*
Enter custom T-SQL here that would run after SQL Server has started up.
*/

IF NOT EXISTS (
    SELECT *
    FROM sys.databases
    WHERE
        name = 'fashion_ecommerce'
)
BEGIN
	CREATE DATABASE fashion_ecommerce
END;
GO