INSERT INTO `smarthint`.`clientes`
(
`NomeRazaoSocial`,
`Email`,
`Telefone`,
`DataCadastro`,
`Bloqueado`,
`Senha`,
`TipoPessoa`,
`CpfCnpj`,
`InscricaoEstadual`,
`Isento`,
`Genero`,
`DataNascimento`)
VALUES
('João da Silva', 'joao.silva@gmail.com', '(11) 99999-8888', '2024-01-14 12:30:00', 0, 'd8f4b15e7fe59f9b8192c8e14a1a50b041f78e0de647c1df5529a1c187548b57', 0, '090.853.559-76', NULL, 1, 1, '1992-03-21'),
('Maria Oliveira', 'maria.oliveira@gmail.com', '(21) 98765-4321', '2024-01-14 10:45:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '12.345.678/9012-34', '554.564.564-654', 0, NULL, NULL),
('Carlos Santos', 'carlos.santos@gmail.com', '(31) 95555-1234', '2024-01-14 15:20:00', 0, '83c694d1dd20b6d27ea38df7627cf1b11b69b5f242ac2e8a6f1818640d5d2b83', 0, '090.123.456-78', NULL, 1, 2, '1980-07-10'),
('Ana Souza', 'ana.souza@gmail.com', '(41) 87654-3210', '2024-01-14 08:15:00', 0, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 0, '111.222.333-44', NULL, 1, 0, '1988-12-05'),
('Ricardo Lima', 'ricardo.lima@gmail.com', '(51) 76543-2109', '2024-01-14 14:00:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '22.333.444/5555-66', '554.564.564-654', 0, NULL, NULL),
('Fernanda Pereira', 'fernanda.pereira@gmail.com', '(61) 98765-4321', '2024-01-14 11:30:00', 0, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 0, '987.654.321-09', NULL, 1, 1, '1995-08-17'),
('Roberto Oliveira', 'roberto.oliveira@gmail.com', '(31) 87654-3210', '2024-01-14 09:45:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '11.222.333/4444-55', '554.564.564-654', 0, NULL, NULL),
('Juliana Silva', 'juliana.silva@gmail.com', '(41) 98765-4321', '2024-01-14 13:20:00', 0, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 0, '333.444.555-66', NULL, 1, 2, '1983-04-25'),
('Empresa XYZ', 'contato@empresa.xyz', '(11) 1234-5678', '2024-01-14 16:45:00', 0, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '55.666.777/0001-88', '999.888.777-66', 0, NULL, NULL),
('ABC Ltda', 'contato@abc.com', '(21) 5555-1234', '2024-01-14 10:30:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '88.999.000/1234-56', '123.456.789-09', 0, NULL, NULL),
('Empresa ABCD', 'contato@abcdcorp.com', '(31) 9876-5432', '2024-01-14 12:15:00', 0, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '12.345.678/9012-34', '987.654.321-09', 0, NULL, NULL),
('XYZ Tech', 'contact@xyztech.com', '(41) 8765-4321', '2024-01-14 14:30:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '33.44.55/6677-88', '111.222.333-44', 0, NULL, NULL),
('Nome de Empresa 1', 'empresa1@business.com', '(41) 8765-4321', '2024-01-14 11:15:00', 1, 'd617c303bf803ad5a37cb98a387769ca80a53c48e3e65fba0eb3b06b07393f6e', 1, '111.222.333/4444-55', '554.564.564-654', 0, NULL, NULL),
('Nome de Empresa 2', 'empresa2@corporation.com', '(51) 98765-4321', '2024-01-14 09:30:00', 0, 'c4b1f60b1cf82f4a95c4777c3ad14b051cc1348eb619f4c663d94d14a3ce4a37', 0, '222.333.444-55', NULL, 1, 1, '1988-11-15'),
('Nome de Empresa 3', 'empresa3@company.com', '(61) 87654-3210', '2024-01-14 13:00:00', 0, 'c3cc67b88ef38cc5e6b3c535ae34959c7c9932e6b5d4e3f90c1c7d9a8f39450e', 0, '987.654.321-09', NULL, 1, 0, '1977-09-03'),
('John Smith', 'john.smith@company.com', '(11) 98765-4321', '2024-01-16 09:30:00', 0, '8d3e97bf140b3315a1ec17a356853bb641d6206c365ba8c65edf7cbb7efde0b1', 0, '111.222.333-44', NULL, 1, 1, '1986-09-12'),
('Emma Johnson', 'emma.johnson@enterprise.com', '(21) 87654-3210', '2024-01-16 14:15:00', 1, 'ae8134d5b7c2a1c8fb75e07a9b94db6981c1b9a4d1ce04c0f7cf6804d35a6287', 1, '12.312.312/3123-21', '554.564.564-654', 0, NULL, NULL),
('Michael Davis', 'michael.davis@business.com', '(31) 95555-1234', '2024-01-16 10:00:00', 0, 'e0fb4bde31a5d6714a8034a48ed330c81eaf6767a4da5c696cc827fd0728949e', 0, '090.123.456-78', NULL, 1, 2, '1991-04-18'),
('XYZ Tech Corp', 'contact@xyztechcorp.com', '(41) 8765-4321', '2024-01-16 15:30:00', 1, 'a0596ff4c7f2bb3dce8b175b4ec0e55e2653dfc51c06753d52a5870a349d74d0', 1, '55.666.777/0001-88', '999.888.777-66', 0, NULL, NULL),
('ACME Corporation', 'contact@acmecorp.com', '(61) 87654-3210', '2024-01-16 13:00:00', 0, 'd8f4b15e7fe59f9b8192c8e14a1a50b041f78e0de647c1df5529a1c187548b57', 0, '12.345.678/9012-34', '987.654.321-09', 0, NULL, NULL),
('Emily White', 'emily.white@company.com', '(41) 8765-4321', '2024-01-16 16:15:00', 1, '83c694d1dd20b6d27ea38df7627cf1b11b69b5f242ac2e8a6f1818640d5d2b83', 1, '33.44.55/6677-88', '111.222.333-44', 0, NULL, NULL);
