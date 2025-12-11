create database BD_HQs;
use BD_HQs;
#Criando Tabela TCadastro
create table Tcadastro(codigo int auto_increment, nome varchar(30), username varchar(30), email varchar(30), senha varchar(250), primary key(codigo));


#preencher tabela tcadastro
#senhas só funcionam pra logar na função password_hash(), então recomendo criar um campo pelo cadastro do site ou inserir por aqui com a senha já passada pelo hash
#Código Admin: 341




#criar trabela hqs
create table Hqs(codigo int auto_increment, nome varchar(100), tipo varchar(30), descricao varchar(2000), link varchar(500), primary key(codigo));

create table Avaliacao(codigo int AUTO_INCREMENT PRIMARY KEY, cod_admin INT NULL, cod_usuario INT NULL, cod_hq INT, comentario VARCHAR(2000), nota INT,
    FOREIGN KEY (cod_usuario) REFERENCES Tcadastro(codigo),
    FOREIGN KEY (cod_hq) REFERENCES Hqs(codigo) );

#senhas só funcionam pra logar na função password_hash(), então recomendo criar um campo pelo cadastro do site
#Código Admin: 341
create table UsAdmin(codigo int auto_increment, nome varchar(30), username varchar(30), email varchar(30), senha varchar(250), primary key(codigo));
insert into UsAdmin(nome,username,email,senha) values
("Mayke", "Mike", "mayke@gmail.com", "$2y$10$o6G6thsDGZ5b1sfB7ZweNecWWpD5FO/5.NWsJodGZrAOrU6JqIM6W");
select * from UsAdmin;
#codigo para cadastrar admin: 341


#preencher tabela hqs
insert into hqs (nome, tipo, descricao, link) values
("Batman Ano Um", "Graphic Novel",
"Em 1986, Frank Miller e David Mazzucchelli produziram esta revolucionária reinterpretação da origem do Batman –
sobre quem ele é e como se tornou o que é. Escrito pouco após Batman: o Cavaleiro das trevas, a distópica fábula de Miller sobre os últimos dias do Homem-Morcego,
Ano um abriu caminho para uma nova visão de um lendário personagem. Esta edição inclui a história na íntegra, uma introdução pelo escritor Frank Miller e um posfácio
ilustrado pelo artista David Mazzucchelli. Inclui também mais de 40 páginas de estudos de personagem, páginas do roteiro original, esboços e fornece mais do que um
vislumbre na criação desse clássico contemporâneo.",
" https://m.media-amazon.com/images/I/61-2G84LF-L._UF1000,1000_QL80_.jpg"),

("Homem-Aranha: A última caçada de Kraven", "Graphic Novel",
"Peter Parker, o Espetacular Homem-Aranha, está prestes a dar um grande passo em sua vida: revelar sua identidade para Mary Jane Watson, sua namorada de longa data.
No entanto, o relacionamento dos pombinhos é posto à prova quando Peter descobre que um velho amigo não era exatamente quem ele pensava. Para piorar, uma terrível
ameaça toma forma: Kraven, o Caçador, que se autodenomina o maior caçador do mundo. Após anos e anos de humilhantes derrotas, Kraven, filho de aristocratas russos,
lança sobre o Homem-Aranha uma investida final. Ele jura destruir Peter Parker. Para ele, no entanto, alvejar sua presa não é o suficiente. Ele quer mesmo é tomar o
lugar de seu inimigo. Assim que ele estiver morto. Apresentado ao leitor brasileiro com exclusividade pela Novo Século, Homem-Aranha: A última caçada de Kraven é uma
incrível - e esperadíssima - adaptação do já clássico conto de loucura e tragédia originalmente assinado por J.M. Dematteis & Mike Zeck.",
"https://m.media-amazon.com/images/I/91TZeW-s9KL._UF894,1000_QL80_.jpg"),

("Ms. Marvel: Nada Normal", "Graphic Novel",
"Kamala Khan era uma garota de New Jersey como muitas outras de sua idade... até o dia em que adquiriu poderes extraordinários! Mas quem realmente é a nova Miss Marvel?
Uma adolescente? Uma muçulmana? Uma inumana? Mas, acima de tudo: conseguirá a jovem responder a estas perguntas ou será esmagada pelo peso da responsabilidade em suas mãos?
Os primórdios de uma das mais importantes, celebradas e comentadas entre as novas heroínas da Marvel, capaz em pouco tempo de conquistar fãs do mundo todo e se tornar um
verdadeiro fenômeno! Um marco moderno da roteirista e escritora G. Willow Wilson (Força-V) e do artista Adrian Alphona (Fugitivos).",
"https://d14d9vp3wdof84.cloudfront.net/image/589816272436/image_h22fte8e85339fr48khsg7vl4e/-S897-FWEBP%22"),

("Grandes Astros: Superman", "Graphic Novel",
"Setenta anos após ser criado e apresentado ao planeta por Joe Shuster e Jerry Siegel, Superman ganhou, em meados da década passada, uma reinterpretação surpreendente que
chocou completa e positivamente o mundo das HQs e redefiniu todos os limites de um personagem icônico, que acreditava-se ser inalterável. Por cortesia da genial e excêntrica
mente do roteirista Grant Morrison e do traço incomparável do desenhista Frank Quitely, o Homem de Aço (e seus milhões de fãs pelo mundo) foram presenteados com uma obra-prima
sem precedentes, publicada em doze partes sob o título Grandes Astros Superman. Agora, essa imperdível obra volta a ser publicada no Brasil pela Panini Books, em uma edição única
e com o tratamento condizente à sua relevância e qualidade. Grandes Astros Superman Ed. Definitiva traz a história na integra em acabamento e formato diferenciados, e acompanhada
por extras inéditos no Brasil!",
"https://m.media-amazon.com/images/I/81WtfAkb5iL._UF1000,1000_QL80_.jpg"),

("Robin III - O Dia da Caçadora # 1", "Minissérie",
"Em “Robin III: o dia da Caçadora # 1” (primeira edição da minissérie em três partes), o menino prodígio atua com o Batman para evitar que diversos crimes aconteçam em Gotham, visto
que várias gangues estão se dirigindo à cidade. Depois que Robin quase foi morto, Batman pede para que ele fique de fora, mas quando o KGBesta aparece, Tim sente-se na obrigação de
ajudar o Batman. E qual o papel da Caçadora nisso tudo? História publicada em “Robin III, cry for Huntress # 1 e # 2” (dezembro de 1992 e janeiro de 1993), com argumento de Chuck Dixon
e desenhos de Tom Lyle.",
"https://rika.vtexassets.com/arquivos/ids/237282-1200-auto?v=635316667491770000&width=1200&height=auto&aspect=true%22"),

("Robin III - O Dia da Caçadora # 2", "Minissérie",
"Rei Cobra se muda para o território da KGBesta e Robin tem novos problemas com seu pai. Robin descobre a identidade secreta da Caçadora, e eles unem forças para encontrar evidências
sobre os agentes russos envolvidos na falsificação. Jack Drake decide mandar Tim para um internato em Metrópolis.",
"https://rika.vtexassets.com/arquivos/ids/237391-1200-auto?v=635316668916070000&width=1200&height=auto&aspect=true%22"),

("Robin III - O Dia da Caçadora # 3", "Minissérie",
"Robin e a Caçadora encontram o quartel-general do Comissário, mas ele leva a Caçadora cativa. Robin tenta resgatá-la, mas também é capturado. Eles enfrentam o KGBesta.",
"https://rika.vtexassets.com/arquivos/ids/237392-1200-auto?v=635316668926930000&width=1200&height=auto&aspect=true%22"),

("Maus: a história de um sobrevivente", "Graphic Novel",
"Maus é um graphic novel do cartunista norte-americano Art Spiegelman, serializado de 1980 a 1991. O quadrinho retrata Spiegelman entrevistando seu pai acerca das experiências deste enquanto um judeu polonês e sobrevivente do Holocausto.",
"https://m.media-amazon.com/images/I/81rV+xVfJAL._AC_UF1000,1000_QL80_.jpg"),

("Gavião Arqueiro: Minha Vida Como uma Arma (Hawkeye #1 - #5)", "Run",
"Matt Fraction, David Aja e uma equipe de artistas incrivelmente talentosos acertam na mosca ao reinventar a lenda do membro mais carismático dos Vingadores, apresentando uma visão totalmente única de Clint Barton quando não está agindo ao lado dos Heróis Mais Poderosos da Terra. Lutando em nome da justiça, dos cãezinhos indefesos e dos churrascos na laje — ao lado de sua indefectível parceira Kate Bishop —, o Gavião Arqueiro vai flechar seu coração enquanto defende seus vizinhos dos perigos de Nova York e da terrível gangue do agasalho de ginástica! Este volume reúne as edições 1 a 5 de Hawkeye e Young Avengers Presentes 6.",
"https://m.media-amazon.com/images/I/81hWNFhMavL._SY522_.jpg"),

("Gavião Arqueiro - Pequenos Acertos (Hawkeye #6 - #11)", "Run",
"A série que reinventou o membro mais carismático dos vingadores! O exímio arqueiro Clint Barton está de volta para lidar com os inúmeros problemas de sua conturbada vida cotidiana: o Furacão Sandy, um apocalipse digital, cachorros detetives, problemas com mulheres, assassinos mercenários e muito mais. Matt Fraction e David Aja continuam com sua empolgante reinvenção do arqueiro Vingador! E ainda: a gangue do agasalho de ginástica está de volta, e quer sangue! Este volume de 140 páginas reúne as edições 6 a 11 de Hawkeye.",
"https://m.media-amazon.com/images/I/4115wobcBtL._SY445_SX342_ML2_.jpg"),

("Gavião Arqueiro - Rio Bravo (Hawkeye #12 - #22)", "Run",
"Abalado pelos acontecimentos recentes, até mesmo o Gavião Arqueiro quer entender seu novo status quo. Quem está com ele? Quem está contra ele? Quem está tentando matá-lo, e por quê? e quando ele achava que estava chegando no fundo do poço, seu irmão aparece. Depois de uma vida de péssimas decisões, Clint e Barney Barton precisam salvar um ao outro — se não acabarem se matando antes. O palhaço assassino Kazi e a Gangue de Agasalho de Ginástica cercam seu prédio, e o round um não vai nada bem. Será que os Bartons se mostrarão um alvo fácil? e você já assistiu Rio Bravo? Vê se não perde, mano. (Hawkeye 12, 13, 15, 17, 19, 21 e 22).",
"https://m.media-amazon.com/images/I/81m0l75-EgL._SY522_.jpg");


