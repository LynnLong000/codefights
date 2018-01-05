char firstNotRepeatingCharacter(string s) {

    int repeated = 0;
    int length = s.Length;

    for (int i = 0; i < length; i++) {
        repeated = 0;
        for (int j = 0; j < length; j++ ){
            if( i != j && s[i] == s[j]){
                repeated = 1;
                 break;
            }
        }

        if(repeated == 0){
            return s[i];
        }
    }
    return '_';
}