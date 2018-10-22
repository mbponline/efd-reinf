﻿/*Config
    RetornaLista
    Retorno
        -R2098Entidade
    Parametros
        -OID_CONTRIBUINTE:decimal
*/

SELECT EFD_R2098.*,
    EFD_ARQUIVO_UPLOAD.DTA_UPLOAD,
    EFD_ARQUIVO_UPLOAD.IND_STATUS
FROM EFD_R2098
INNER JOIN EFD_ARQUIVO_UPLOAD ON EFD_ARQUIVO_UPLOAD.OID_ARQUIVO_UPLOAD = EFD_R2098.OID_ARQUIVO_UPLOAD
WHERE OID_CONTRIBUINTE = @OID_CONTRIBUINTE