-- Desabilitar constraints de chave estrangeira
ALTER TABLE Cliente NOCHECK CONSTRAINT ALL;
ALTER TABLE Cidade NOCHECK CONSTRAINT ALL;
ALTER TABLE Pedido NOCHECK CONSTRAINT ALL;

-- Deletar dados das tabelas
DELETE FROM Cliente;
DELETE FROM Cidade;
DELETE FROM Pedido;

-- Habilitar constraints de chave estrangeira
ALTER TABLE Cliente WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Cidade WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Pedido WITH CHECK CHECK CONSTRAINT ALL;