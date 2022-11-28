
create procedure [dbo].[AddSaleBill]
(@billDate nvarchar(max),@billTotal decimal(10,2),@billReciption decimal(10,2),@customerID int ,@billType nvarchar(50),@salerID int)
 
as

begin--begin main block
Begin Try
--insert data
insert into SalesBill(bill_Date,bill_total,bill_rceiption,bill_type,bill_saler,customer)
values(@billDate,@billTotal,@billReciption,@billType,@salerID,@customerID)

End Try

Begin Catch

    SELECT
          ERROR_NUMBER() AS ErrorNumber
		 ,ERROR_SEVERITY() AS ErrorSeverity
		 ,ERROR_STATE() AS ErrorState
		 ,ERROR_PROCEDURE() AS ErrorProcedure
		 ,ERROR_MESSAGE() AS ErrorMessage
End Catch
end;--end main block