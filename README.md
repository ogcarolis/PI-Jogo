# PI-Jogo
Jogo de PI

try
                {

                    if (jVez.Id == this.meuJogador.Id)
                    {
                        if (this.cartas.Count >= 2)
                        {
                            int posicao = this.random.Next(0, this.meusPiratas.Count);
                            int carta = this.random.Next(0, this.cartas.Count);

                            this.game.moverPirata(this.meuJogador, this.meusPiratas[posicao].Posicao, this.cartas[carta].Simbolo);
                            exibirPiratas();
                            exibirCartas();

                        }
                        else
                        {
                            int posicao = this.random.Next(0, this.meusPiratas.Count);

                            if (this.meusPiratas[posicao].Posicao > 1)
                            {
                                this.game.voltarPirata(this.meuJogador, this.meusPiratas[posicao].Posicao);
                                exibirPiratas();
                                exibirCartas();
                            }
                            else
                            {
                                this.game.pularVez(this.meuJogador);
                                exibirPiratas();
                                exibirCartas();
                            }
                        }
                    }
                }
                catch (Exception e1)
                {
                    enviaMsg(e1.Message, "erro");
                }
