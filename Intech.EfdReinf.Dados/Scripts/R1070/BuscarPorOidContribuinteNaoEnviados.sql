﻿/*Config
    RetornaLista
    Retorno
        -R1070Entidade
    Parametros
        -OID_CONTRIBUINTE:decimal
*/

SELECT EFD_R1070.*,
    EFD_ARQUIVO_UPLOAD.DTA_UPLOAD,
    EFD_ARQUIVO_UPLOAD.IND_STATUS
FROM EFD_R1070
INNER JOIN EFD_ARQUIVO_UPLOAD ON EFD_ARQUIVO_UPLOAD.OID_ARQUIVO_UPLOAD = EFD_R1070.OID_ARQUIVO_UPLOAD
WHERE OID_CONTRIBUINTE = @OID_CONTRIBUINTE
  AND IND_SITUACAO_PROCESSAMENTO = 'IMP'