CREATE PROCEDURE INSERT_QUERY_LOG(@AGE				INTEGER,
                                  @AMOUNT			DECIMAL(20,2),
                                  @MONTHS			INT,  
                                  @USER_LOG			VARCHAR(50))
AS  
  BEGIN
		DECLARE @PAYMENT	DECIMAL(12,2)
		DECLARE @RATE		DECIMAL(5,2)

		SET @RATE	 = (SELECT RATE FROM AGE_RATE WHERE(AGE = @AGE))
		SET @PAYMENT = ((@AMOUNT * @RATE)/@MONTHS)

		INSERT INTO QUERY_LOG(QUERY_DATE, AGE, AMOUNT,MONTHS, MONTHLY_PAYMENT, QUERY_IP)
		VALUES
		(
			GETDATE(),
			@AGE,
			@AMOUNT,
			@MONTHS,
			@PAYMENT,
			@USER_LOG
		)
		return @PAYMENT
  END



  exec INSERT_QUERY_LOG @age = 18, @amount= 150000, @months = 12, @USER_LOG = 'PruebaProcedure'