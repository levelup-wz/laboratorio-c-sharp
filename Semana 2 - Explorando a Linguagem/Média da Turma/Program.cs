using Média_da_Turma;

Aluno Ana = new Aluno();
Ana.AdicionaNota(6.8);

Aluno Bia = new Aluno();
Bia.AdicionaNota(7.9);

Aluno Caio= new Aluno();
Caio.AdicionaNota(6.1);

Aluno Dani = new Aluno();
Dani.AdicionaNota(10);

Aluno Eli  = new Aluno();
Eli.AdicionaNota(5.4);

List<Aluno> notasDosAlunos = new List<Aluno>
{
    Ana,
    Bia,
    Caio,
    Dani,
    Eli
};

double mediaDaTurma = Turma.MediaDaTurma(notasDosAlunos);
string aprovacao = "Turma reprovada!";
if(mediaDaTurma > 7) aprovacao= "Turma aprovada!";

Console.WriteLine($"A média da turma foi de {mediaDaTurma} - {aprovacao}");