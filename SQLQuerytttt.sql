
create procedure GetSaleBillDetails(@bill_id bigint)
as
begin--begin main block
Begin Try
--select  drug_name "اسم الصنف",user_phone "التلفون",userAdress "العنوان ",user_sex "النوع",user_masterType "الصلاحيات" from Drugs
----select drug_id,drug_name from Drugs
select Drugs.drug_name "الصنف",SalesBillDedails.drug_type "النوع",Drugs.companyName "الشركة",SalesBillDedails.drug_quantity "الكمية",
SalesBillDedails.drug_price "سعر الوحدة",SalesBillDedails.drug_price*SalesBillDedails.drug_quantity "المجموع"
from SalesBillDedails,Drugs
where SalesBillDedails.bill_id=@bill_id and SalesBillDedails.drug_id=Drugs.drug_id;


--declare
-- @drugid  bigint ;
 
-- insert into Drugs(drug_name,drug_type,companyName,drug_exp_date,drug_quantity,drug_purch_price,drug_sale_price)
-- values(@DrugName,@drugType,@companyName,@expDate,@quantity,@onePrice,@salPrice);
-- set @drugid= (select drug_id from Drugs 
-- where drug_name=@DrugName and drug_type=@drugType and drug_sale_price=@salPrice
-- and drug_purch_price=@onePrice
 
-- );
--insert into PurchasesDetails(bill_id,drug_id,drug_Type,drug_quantity,drug_price)
--values(@bill_ID,@drugID,@drugType,@quantity,@onePrice)

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