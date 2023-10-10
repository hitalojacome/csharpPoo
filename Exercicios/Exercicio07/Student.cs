namespace Exercicio7 {
    class Student {

        public string Name;
        public double FirstGrade;
        public double SecondGrade;
        public double ThirdGrade;

        public double FinalGrade() {
            return FirstGrade + SecondGrade + ThirdGrade;
        }

        public bool Approved() {
            if (FinalGrade() >= 60.0) {
            return true;
            } else {
                return false;
            }
        }

        public double RemainingGrade() {
            if (Approved()) {
                return 0.0;
            } else {
                return 60.0 - FinalGrade();
            }
        }

    }
}