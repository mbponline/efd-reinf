﻿/*Config
	RetornaLista
    Retorno
        -R2099Entidade
    Parametros
        -OID_CONTRIBUINTE:decimal
		-ANO:int
		-MES:int
		-IND_SITUACAO_PROCESSAMENTO:string
*/

SELECT * 
FROM EFD_R2099
WHERE OID_CONTRIBUINTE = @OID_CONTRIBUINTE
  AND YEAR(DTA_PERIODO_APURACAO) >= @ANO
  AND MONTH(DTA_PERIODO_APURACAO) <= @MES
  AND IND_SITUACAO_PROCESSAMENTO = @IND_SITUACAO_PROCESSAMENTO