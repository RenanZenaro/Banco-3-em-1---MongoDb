// executar no terminal
// mongosh "mongodb+srv://cluster0.5fj4e.mongodb.net/" --apiVersion 1 --username admin

--acessar um banco
use banda3em1Db

--verificar os bancos existentes
show dbs

--verificar as coleções de um banco
show collections

--criar uma coleção
db.createCollection("banda")

--CREATE
db.heroes.insertOne({
    logo: "",
    nome: "Banda 3 em 1",
    integrantes: ["Renan Zenaro", "Lucas Pagnota", "Nicolly Kannanda", "Leando Alves"],
    email: "bandatresemum@gmail.com",
    facebook: "Banda 3 em 1",
    instagram: "@_banda3em1",
    youtube: "https://www.youtube.com/@em-yi1rl",
    whatsapp: ["(14) 99873-9851", "(14) 99895-1799", "(14) 99161-9753", "(14) 98200-0517"],
    cidade: "Barra Bonita",
    estado: "SP",
    historia: "Em 2018, três adolescentes - Renan (bateria), Lucas (violão/guitarra) e Nicolly (vocal) - decidiram formar uma banda, mesmo ainda estando em fase de aprendizado musical. No ano seguinte, em 2019, começaram a se apresentar em eventos locais, como aniversários, festas e bares como um trio. Entretanto, em 2020, a pandemia interrompeu suas atividades temporariamente. Em 2022, com a retomada das apresentações, a banda trouxe Leandro para assumir o papel de baixista. Desde então estão na ativa e continuam tocando juntos."
    midia: ""
})


db.createCollection("eventos")

db.heroes.insertOne({
    local: "Jeremias Bar",
    data: "23/11/24",
    descricao: ""
})


db.createCollection("projeto")

db.heroes.insertOne({
    nome: "Projeto Acústico",
    integrantes: ["Renan Zenaro", "Lucas Pagnota", "Nicolly Kannanda"],
    midia: ""
})