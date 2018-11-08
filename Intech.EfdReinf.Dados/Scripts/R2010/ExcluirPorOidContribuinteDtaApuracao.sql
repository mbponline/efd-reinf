﻿/*Config
    Retorno
        -R2010Entidade
    Parametros
        -OID_CONTRIBUINTE:decimal
		-DTA_APURACAO:DateTime
*/

DELETE
FROM EFD_R2010
WHERE EFD_R2010.OID_CONTRIBUINTE = @OID_CONTRIBUINTE
  AND EFD_R2010.DTA_APURACAO = @DTA_APURACAO
  AND EFD_R2010.IND_SITUACAO_PROCESSAMENTO IN('IMP', 'PRO')