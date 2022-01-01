## Todos os objetos devem retornar via ReturnContent

# Orchestrator:
	Login
	Logout

	StartBot
	StopBot

	BuyTokenToTrade
	BuyPrieceIsLessThan
	BuyPrieciIsNPercentLessThanSell
	BuyMaxSlippage
	BuyTokenAmount
	BuyTimes

	SellTokenToTrade
	SellPrieceIsLessThan
	SellPrieciIsNPercentMoreThanBuy
	SellMaxSlippage
	SellTokenAmount
	SellTimes

	TradeTokenToToken?????

	GetBalanceInWei (unidadeMinima)
	GetBalanceInBNB

	TransferToAnotherWallet
	TransferToAnotherWalletIfValueIsMoreThen	

	CheckSellAmountBasedOnBuyAmount
	CheckBuyAmountBasedOnSellAmount

	TimeToCheckLiquidity(in ms)

	GasLimit
	WaitFinishOperationToDoNew 

	RPCUrl
	InternetURL

	CheckLatencyWithBlockChain(every 1 second)	--> Label
	CheckLatencyWithInternet(every 1 second)	--> Label

	SetTelegramUser
	SendTelegramMessage
	IntegrationWithTelegram

# Business
	=>ToDo Continuar daqui


	PasswordBusiness
		// bool logged LogInWalletAsync(string password, string localFileAdress) (Obtem o hash da senha, verifica se está correto com o arquivo)
		bool valid ValidatePasswordMetrics(string passwordHash) (primeira verificação antes de validar se o password está correto nos dois campos)
		bool valid ValidateSecondPasswordMatch(string passwordHash, string secondpasswordHash)

# Adapter:

	TokenAdapter
		obj token TokenGetBalanceAsync(string tokenAdress)
		obj token TokenGetAllFromBlockChainAsync(string tokenAdress, string tokenToCompare)(todos os dados da blockchain para o tokken)
		obj operation TokenBuyAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)(Usa o TokenTrade)
		obj operation TokenSellAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)(Usa o TokenTrade)
		obj operation TokenTradeAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits)
		obj operation TokenTradeCalculateAsync(obj tokenDestination, obj tokenOrign, obj feeLimits) (Origin ou Destination está com o montante vazio e este será preenchido nesse método e retornado através do Operation)

	LogAdapter
		bool saved SaveLastLocalExecutedOperationAsync(obj tokenDestination, obj tokenOrigin, obj feeLimits) (salvar em arquivo .log)
		obj? operation GetLastLocalExecutedOperationAsync() (Log salvo em arquivo de texto) (ler arquivo .log salvo no diretório local da aplicação)
		
	SecureWalletAdapter
		obj? wallet DecriptAsync() ()
		obj? wallet SaveEncryptedAsync (obj Wallet, string passwordHash)
		// SignInWalletAsync(obj wallet, string passwordHash)(salva os dados da wallet como adress privado para não necessitar obter e digitar o mesmo todas as vezes, pois seria um problema de segurança e usabilidade)


# ToExternalLibrary
	GetHash(string text)retorna o hash com base no texto passado