﻿using MauiAppShowDoMilhão.Models;

namespace MauiAppShowDoMilhão
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }

            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rio de Janeiro"},
                    new Alternativa { Correta = true, Descricao = "Rio Grande do Sul"},
                    new Alternativa { Correta = false, Descricao = "Santa Catarina"},
                    new Alternativa { Correta = false, Descricao = "Goiás"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Gauchinha"},
                    new Alternativa { Correta = true, Descricao = "Paulistinha"},
                    new Alternativa { Correta = false, Descricao = "Pimentinha"},
                    new Alternativa { Correta = false, Descricao = "Andorinha"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Margarida"},
                    new Alternativa { Correta = true, Descricao = "Minnie"},
                    new Alternativa { Correta = false, Descricao = "A Pequena Sereia"},
                    new Alternativa { Correta = false, Descricao = "Olívia Palito"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Cuca"},
                    new Alternativa { Correta = false, Descricao = "Negrinho do Pastoreiro"},
                    new Alternativa { Correta = false, Descricao = "Boitatá"},
                    new Alternativa { Correta = true, Descricao = "Saci-Pererê"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Jamaica"},
                    new Alternativa { Correta = true, Descricao = "Cuba"},
                    new Alternativa { Correta = false, Descricao = "El Salvador"},
                    new Alternativa { Correta = false, Descricao = "Mexico"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república do Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Duque de Caxias"},
                    new Alternativa { Correta = false, Descricao = "Marechal Rondon"},
                    new Alternativa { Correta = false, Descricao = "Dom Pedro II"},
                    new Alternativa { Correta = true, Descricao = "Marechal Deodoro"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Marechal Deodoro"},
                    new Alternativa { Correta = false, Descricao = "Barão de Mauá"},
                    new Alternativa { Correta = true, Descricao = "Duque de Caxias"},
                    new Alternativa { Correta = false, Descricao = "Marques de Pombal"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Raul Gil"},
                    new Alternativa { Correta = false, Descricao = "Bolinha"},
                    new Alternativa { Correta = false, Descricao = "Flávio Cavalcante"},
                    new Alternativa { Correta = true, Descricao = "Chacrinha"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Monstro"},
                    new Alternativa { Correta = false, Descricao = "Gorila"},
                    new Alternativa { Correta = false, Descricao = "Príncipe"},
                    new Alternativa { Correta = false, Descricao = "Sapo"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Virgem"},
                    new Alternativa { Correta = false, Descricao = "Aquário"},
                    new Alternativa { Correta = true, Descricao = "Capricórnio"},
                    new Alternativa { Correta = false, Descricao = "Áries"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Harrison Ford"},
                    new Alternativa { Correta = false, Descricao = "Gerald Ford"},
                    new Alternativa { Correta = true, Descricao = "Henry Ford"},
                    new Alternativa { Correta = false, Descricao = "Anna Ford"},
                }
            },
            new Pergunta
            {
                Id = 13  ,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Preta"},
                    new Alternativa { Correta = false, Descricao = "Vermelha"},
                    new Alternativa { Correta = false, Descricao = "Azul"},
                    new Alternativa { Correta = true, Descricao = "Verde"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "200"},
                    new Alternativa { Correta = true, Descricao = "100"},
                    new Alternativa { Correta = false, Descricao = "170"},
                    new Alternativa { Correta = false, Descricao = "220"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 de Abril"},
                    new Alternativa { Correta = false, Descricao = "12 de Outubro"},
                    new Alternativa { Correta = true, Descricao = "7 de Setembro"},
                    new Alternativa { Correta = false, Descricao = "25 de Dezembro"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Veneza"},
                    new Alternativa { Correta = false, Descricao = "Vitória"},
                    new Alternativa { Correta = false, Descricao = "Vancouver"},
                    new Alternativa { Correta = true, Descricao = "Vaticano"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase:“Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Médicos"},
                    new Alternativa { Correta = true, Descricao = "Escoteiros"},
                    new Alternativa { Correta = false, Descricao = "Bombeiros"},
                    new Alternativa { Correta = false, Descricao = "Policiais"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Romeu"},
                    new Alternativa { Correta = false, Descricao = "Orfeu"},
                    new Alternativa { Correta = false, Descricao = "Hamlet"},
                    new Alternativa { Correta = false, Descricao = "Iago"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Nove"},
                    new Alternativa { Correta = false, Descricao = "Dez"},
                    new Alternativa { Correta = false, Descricao = "Onze"},
                    new Alternativa { Correta = true, Descricao = "Doze"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Paraná"},
                    new Alternativa { Correta = false, Descricao = "Santa Catarina"},
                    new Alternativa { Correta = false, Descricao = "São Paulo"},
                    new Alternativa { Correta = true, Descricao = "Bahia"},
                }
            },

        };

        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Seis"},
                    new Alternativa { Correta = false, Descricao = "Oito"},
                    new Alternativa { Correta = false, Descricao = "Dez"},
                    new Alternativa { Correta = true, Descricao = "Doze"},
                }
            },
            new Pergunta
            {
                Id = 22,
                Enunciado = "Qual é o país do tango?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Uruguai"},
                    new Alternativa { Correta = true, Descricao = "Argentina"},
                    new Alternativa { Correta = false, Descricao = "Paraguai"},
                    new Alternativa { Correta = false, Descricao = "Espanha"},
                }
            },
            new Pergunta
            {
                Id = 23,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Trajano"},
                    new Alternativa { Correta = true, Descricao = "Nero"},
                    new Alternativa { Correta = false, Descricao = "Brutus"},
                    new Alternativa { Correta = false, Descricao = "Calígula"},
                }
            },
            new Pergunta
            {
                Id = 24,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Japão"},
                    new Alternativa { Correta = false, Descricao = "México"},
                    new Alternativa { Correta = true, Descricao = "Itália"},
                    new Alternativa { Correta = false, Descricao = "Estados Unidos"},
                }
            },
            new Pergunta
            {
                Id = 25,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Milanense"},
                    new Alternativa { Correta = false, Descricao = "Milanoso"},
                    new Alternativa { Correta = false, Descricao = "Milista"},
                    new Alternativa { Correta = true, Descricao = "Milanês"},
                }
            },
            new Pergunta
            {
                Id = 26,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Carpinteiro"},
                    new Alternativa { Correta = false, Descricao = "Relojoeiro"},
                    new Alternativa { Correta = false, Descricao = "Confeiteiro"},
                    new Alternativa { Correta = false, Descricao = "Bombeiro"},
                }
            },
            new Pergunta
            {
                Id = 27,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Morumbi"},
                    new Alternativa { Correta = false, Descricao = "Pacaembu"},
                    new Alternativa { Correta = true, Descricao = "Maracanã"},
                    new Alternativa { Correta = false, Descricao = "Mineirão"},
                }
            },
            new Pergunta
            {
                Id = 28,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Vulcão"},
                    new Alternativa { Correta = false, Descricao = "Comida"},
                    new Alternativa { Correta = true, Descricao = "Instrumento Musical"},
                    new Alternativa { Correta = false, Descricao = "Tribo Indígena"},
                }
            },
            new Pergunta
            {
                Id = 29,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Camicases"},
                    new Alternativa { Correta = false, Descricao = "Sashimis"},
                    new Alternativa { Correta = false, Descricao = "Haraquiris"},
                    new Alternativa { Correta = false, Descricao = "Sumôs"},
                }
            },
            new Pergunta
            {
                Id = 30,
                Enunciado = "O que é gôndola?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Embarcação"},
                    new Alternativa { Correta = false, Descricao = "Brinquedo"},
                    new Alternativa { Correta = false, Descricao = "Música"},
                    new Alternativa { Correta = false, Descricao = "Símbolo"},
                }
            },
            new Pergunta
            {
                Id = 31,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Japão"},
                    new Alternativa { Correta = false, Descricao = "China"},
                    new Alternativa { Correta = false, Descricao = "Índia"},
                    new Alternativa { Correta = false, Descricao = "Indonésia"},
                }
            },
            new Pergunta
            {
                Id = 32,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Primeira Dama"},
                    new Alternativa { Correta = false, Descricao = "Dona-Prima"},
                    new Alternativa { Correta = true, Descricao = "Prima-Dona"},
                    new Alternativa { Correta = false, Descricao = "Obra-Prima"},
                }
            },
            new Pergunta
            {
                Id = 33,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Inseto"},
                    new Alternativa { Correta = true, Descricao = "Árvore"},
                    new Alternativa { Correta = false, Descricao = "Verme"},
                    new Alternativa { Correta = false, Descricao = "Verdura"},
                }
            },
            new Pergunta
            {
                Id = 34,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Mar"},
                    new Alternativa { Correta = true, Descricao = "Montanha"},
                    new Alternativa { Correta = false, Descricao = "Rio"},
                    new Alternativa { Correta = false, Descricao = "Praia"},
                }
            },
            new Pergunta
            {
                Id = 35,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Paris"},
                    new Alternativa { Correta = false, Descricao = "Copenhague"},
                    new Alternativa { Correta = true, Descricao = "Roma"},
                    new Alternativa { Correta = false, Descricao = "Londres"},
                }
            },
            new Pergunta
            {
                Id = 36,
                Enunciado = "Qual é o ponto mais alto da Terra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Everest"},
                    new Alternativa { Correta = false, Descricao = "Monte Sinai"},
                    new Alternativa { Correta = false, Descricao = "Monte Castelo"},
                    new Alternativa { Correta = false, Descricao = "Mont Blanc"},
                }
            },
            new Pergunta
            {
                Id = 37,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "Tâmisa"},
                    new Alternativa { Correta = false, Descricao = "Sena"},
                    new Alternativa { Correta = false, Descricao = "Reno"},
                    new Alternativa { Correta = false, Descricao = "Aube"},
                }
            },
            new Pergunta
            {
                Id = 38,
                Enunciado = "Qual é a raça do pernagem principal do filme “Beethoven”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Fila"},
                    new Alternativa { Correta = false, Descricao = "Pastor Alemão"},
                    new Alternativa { Correta = false, Descricao = "Poodle"},
                    new Alternativa { Correta = true, Descricao = "São-Bernardo"},
                }
            },
            new Pergunta
            {
                Id = 39,
                Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Nelson Piquet"},
                    new Alternativa { Correta = true, Descricao = "Nelson Mandela"},
                    new Alternativa { Correta = false, Descricao = "Nelson Ned"},
                    new Alternativa { Correta = false, Descricao = "John Nelson"},
                }
            },
            new Pergunta
            {
                Id = 40,
                Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Orlando Silva"},
                    new Alternativa { Correta = false, Descricao = "Vicente Celestino"},
                    new Alternativa { Correta = true, Descricao = "Francisco Alves"},
                    new Alternativa { Correta = false, Descricao = "Carlos Galhardo"},
                }
            },


        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
