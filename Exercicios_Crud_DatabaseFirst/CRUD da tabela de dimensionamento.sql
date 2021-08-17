-- Script de procedimentos Inseriri, atualizar e excluir a tabela de dimensionamento 
Use DB_ECCUSBET
Go
-- Procedimenso de inseir dados 
Create proc SP_InserirDados_TbDimensionamento
@Novo_Volume_Util as float,
@Nova_Largura as float,
@Novo_Comprimento as float,
@Nova_Profundidade as float,
@NovaQte_Pneus as int
as 
insert into [dbo].[Tabela de Dimensionamento] ([Volume útil (m³)],[Largura (m)], [Comprimento da Bacia (m)],[Profundidade (m)],[Quantidade de Pneus])
values (@Novo_Volume_Util, @Nova_Largura, @Novo_Comprimento, @Nova_Profundidade, @NovaQte_Pneus)
Go

-- Procedimento para atualizar dados
Create proc SP_AtualizarDados_TbDimensionamento
@IdAtualizado as int,
@Novo_Volume_Util as float,
@Nova_Largura as float,
@Novo_Comprimento as float,
@Nova_Profundidade as float,
@NovaQte_Pneus as int
as 
Update [dbo].[Tabela de Dimensionamento]
Set [Volume útil (m³)] = @Novo_Volume_Util, [Largura (m)] = @Nova_Largura,
[Comprimento da Bacia (m)] = @Novo_Comprimento, [Profundidade (m)] = @Nova_Profundidade,
[Quantidade de Pneus] = @NovaQte_Pneus where [IdDimensionamento] = @IdAtualizado
Go

--Excluir dados
Create proc SP_ExcluirDados_TbDimensionamento
@LinhaExcluida as int as delete from [dbo].[Tabela de Dimensionamento] where [IdDimensionamento] = @LinhaExcluida
Go

Create proc SP_Carregar_TbDimensionamento
as
Select * From [dbo].[Tabela de Dimensionamento]
Go