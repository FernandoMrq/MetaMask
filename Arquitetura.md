## Todos os objetos devem retornar via ReturnContent

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--
# Orchestrator:

##	SecureWalletOrchestrator
		Login
		Logout
		LogoutAndSave

##	OperationsOrchestrator
		BotStart
		BotStop

##	OperationsOrchestrator
		BuySetTokenToTrade
		BuySetPrieceIsLessThan
		BuySetPrieciIsNPercentLessThanSell
		BuySetMaxSlippage
		BuySetTokenAmount
		BuySetTimes
		BuySetMinBalance
		BuySetGasLimit
		BuyWaitFinishOperationToDoNew

		SellSetTokenToTrade
		SellSetPrieceIsLessThan
		SellSetPrieciIsNPercentMoreThanBuy
		SellSetMaxSlippage
		SellSetTokenAmount
		SellSetTimes
		SellSetMinBalance
		SellSetGasLimit
		SellWaitFinishOperationToDoNew

		GetBestGasLimit
##	WalletOrchestrator
		GetBalanceInWei (unidadeMinima)
		GetBalanceInBNB
		TransferToAnotherWallet
		TransferToAnotherWalletIfValueIsMoreThen	
		TradeTokenToToken?????
		CheckSellAmountBasedOnCurrentAmount
		CheckBuyAmountBasedOnCurrentAmount

##	ConfigurationOrchestrator
		SetTimeToCheckLiquidity(in ms)		--> Save in generic configuration file
		SetRPCUrl							--> Save in generic configuration file
		SetInternetURL						--> Save in generic configuration file

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--
# Business

##	SecureWalletBusiness
		Login			--> DecriptAsync
		Logout			--> DisposeWallet
		LogoutAndSave	--> SaveEncryptedAsync

##	OperationsBusiness
		Thread StopBuyOperation		--> Seta uma variável que para a thread
		Thread BuyGetBestMoment		-->	Usa as proriedades setadas em:
												BuySetTokenToTrade
												BuySetPrieceIsLessThan
												BuySetPrieciIsNPercentLessThanSell
												BuySetMaxSlippage
												BuySetTokenAmount
												BuySetTimes
												BuySetMinBalance
												BuySetGasLimit
												BuyWaitFinishOperationToDoNew

		Thread StopSellOperation	--> Seta uma variável que para a thread
		Thread SellGetBestMoment	--> Usa as proriedades setadas em:
												SellSetTokenToTrade
												SellSetPrieceIsLessThan
												SellSetPrieciIsNPercentMoreThanBuy
												SellSetMaxSlippage
												SellSetTokenAmount
												SellSetTimes
												SellSetMinBalance
												SellSetGasLimit
												SellWaitFinishOperationToDoNew

		Thread StopAllOperation		--> Seta uma variável que para a thread

		GetBestGasLimit
		
		BuySetTokenToTrade
		BuySetPrieceIsLessThan
		BuySetPrieciIsNPercentLessThanSell
		BuySetMaxSlippage
		BuySetTokenAmount
		BuySetTimes
		BuySetMinBalance
		BuySetGasLimit
		BuyWaitFinishOperationToDoNew

		SellSetTokenToTrade
		SellSetPrieceIsLessThan
		SellSetPrieciIsNPercentMoreThanBuy
		SellSetMaxSlippage
		SellSetTokenAmount
		SellSetTimes
		SellSetMinBalance
		SellSetGasLimit 
		SellWaitFinishOperationToDoNew

##	WalletBusiness
		GetBalanceInWei (unidadeMinima)
		GetBalanceInBNB
		TransferToAnotherWallet
		TransferToAnotherWalletIfValueIsMoreThen	
		TradeTokenToToken?????
		CheckSellAmountBasedOnCurrentAmount
		CheckBuyAmountBasedOnCurrentAmount

##	PasswordBusiness
		// bool logged LogInWalletAsync(string password, string localFileAdress) (Obtem o hash da senha, verifica se está correto com o arquivo)
		bool valid ValidatePasswordMetrics(string passwordHash) (primeira verificação antes de validar se o password está correto nos dois campos)
		bool valid ValidateSecondPasswordMatch(string passwordHash, string secondpasswordHash)

##	ConfigurationBusiness
		SetTimeToCheckLiquidity(in ms)		--> Save in generic configuration file
		SetRPCUrl							--> Save in generic configuration file
		SetInternetURL						--> Save in generic configuration file

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--
# Adapter:

##	TokenAdapter
		obj token TokenGetBalanceAsync(string tokenAdress)
		obj token TokenGetAllFromBlockChainAsync(string tokenAdress, string tokenToCompare)(todos os dados da blockchain para o tokken)
		obj operation TokenBuyAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)(Usa o TokenTrade)
		obj operation TokenSellAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)(Usa o TokenTrade)
		obj operation TokenTradeAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)
		obj operation TokenTradeCalculateAsync(obj tokenDestination, obj tokenOrign, obj feeLimits) (Origin ou Destination está com o montante vazio e este será preenchido nesse método e retornado através do Operation)

##	LogAdapter
		bool saved SaveLastLocalExecutedOperationAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits) (salvar em arquivo .log)
		obj? operation GetLastLocalExecutedOperationAsync() (Log salvo em arquivo de texto) (ler arquivo .log salvo no diretório local da aplicação)
		
##	SecureWalletAdapter
		obj? wallet DecriptAsync() ()
		obj? wallet SaveEncryptedAsync (obj Wallet, string passwordHash)
		// SignInWalletAsync(obj wallet, string passwordHash)(salva os dados da wallet como adress privado para não necessitar obter e digitar o mesmo todas as vezes, pois seria um problema de segurança e usabilidade)

##	BSCScanAdapter
		obj? token GetCurrentValueOfTokenInBusd()
		obj? token GetCurrentValueOfTokenInDefaultPair()
		obj? Thread GetApiKeyForSolicitation()	--> Retorna a chave da próxima Api a ser usada, sempre salva a hora e segundos em que fez a solicitação, a API e quantas vezes ela já foi usada, tudo isso pra poder validar se é a próxima que pode ser usada

##	LatencyAdapter
	CheckLatencyWithBlockChain(every 1 second)	--> Label posteriormente
	CheckLatencyWithInternet(every 1 second)	--> Label posteriormente

##	TelegramAdapter
	??	SetTelegramUser
	??	SendTelegramMessage
	??	IntegrationWithTelegram

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--
##	ToExternalLibrary
		GetHash(string text)retorna o hash com base no texto passado

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--

Definir objeto Token
Definir objeto Configuration
Definir Objeto Wallet

## --//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--