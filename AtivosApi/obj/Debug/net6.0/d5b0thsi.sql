CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Ativos` (
    `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
    `AtivoNome` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Data` datetime(6) NOT NULL,
    `Valor` decimal(65,30) NOT NULL,
    `VariacaoDiaAnterior` decimal(65,30) NOT NULL,
    `VariacaoPrimeiraData` decimal(65,30) NOT NULL,
    CONSTRAINT `PK_Ativos` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230304203140_CriandoTabelaDeAtivo', '7.0.3');

COMMIT;

