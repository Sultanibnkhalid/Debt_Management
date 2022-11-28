
create procedure AddPurchaDetails(@bill_ID bigint,@DrugName nvarchar(max),@drugType nvarchar(max)
,@companyName nvarchar(max),@expDate nvarchar(max),
 @quantity int,@onePrice decimal(18,2),@salPrice decimal(18,2))
as
begin--begin main block
Begin Try
--select  drug_name "اسم الصنف",user_phone "التلفون",userAdress "العنوان ",user_sex "النوع",user_masterType "الصلاحيات" from Drugs
--select drug_id,drug_name from Drugs
--insert Into Suppleirs(sup_name,sup_phone,sup_Address)
--values(@name,@phon,@address);
declare
 @drugid  bigint ;
 
 insert into Drugs(drug_name,drug_type,companyName,drug_exp_date,drug_quantity,drug_purch_price,drug_sale_price)
 values(@DrugName,@drugType,@companyName,@expDate,@quantity,@onePrice,@salPrice);
 set @drugid= (select drug_id from Drugs 
 where drug_name=@DrugName and drug_type=@drugType and drug_sale_price=@salPrice
 and drug_purch_price=@onePrice
 
 );
insert into PurchasesDetails(bill_id,drug_id,drug_Type,drug_quantity,drug_price)
values(@bill_ID,@drugID,@drugType,@quantity,@onePrice)

end try
Begin Catch

    SELECT
          ERROR_NUMBER() AS ErrorNumber
		 ,ERROR_SEVERITY() AS ErrorSeverity
		 ,ERROR_STATE() AS ErrorState
		 ,ERROR_PROCEDURE() AS ErrorProcedure
		 ,ERROR_MESSAGE() AS ErrorMessage
End Catch
end;--end main block