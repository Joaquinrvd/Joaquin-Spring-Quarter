//
//  AboutJoaquin.swift
//  Spring Project
//
//  Created by Joaquin Robert Vincent-DaGrace on 5/6/26.
//

import SwiftUI

struct AboutJoaquin: View {
    var body: some View {
        VStack {
            ScrollView {
                Image("Sekiro1")
                    .resizable()
                    .frame(width: 500, height: 500)
                    .padding()
                    .shadow(color: .gray, radius: 3, x: 0, y: 5)
                Text("Sekiro")
                
                
                Text("Sekiro: Shadows Die Twice is an action-adventure souls-like game developed by FromSoftware and published by Sony Interactive Entertainment. The game takes place in a fictional version of Sengoku-era Japan filled with war, corruption, and supernatural enemies. You play as a skilled shinobi named Wolf, whose mission is to protect his young master, Kuro, the Divine Heir. After failing to save him and losing his left arm in battle, Wolf is rescued and given a powerful prosthetic arm that can be equipped with different weapons and tools.Throughout the game, Wolf travels across dangerous castles, villages, temples, and battlefields while fighting deadly enemies, monsters, and powerful bosses. Unlike many other souls games, combat in Sekiro focuses heavily on sword fighting, parrying attacks, breaking enemy posture, and fast movement instead of leveling up stats. The game also includes stealth mechanics that allow players to sneak past enemies or perform stealth kills.As Wolf searches for his master, he uncovers secrets about immortality, loyalty, and sacrifice. The story explores themes of honor and revenge while giving players multiple endings depending on the choices they make during the game. Hidetaka Miyazaki, the director of the game, designed Sekiro to reward patience, precision, and mastery of combat, making it one of the most challenging and respected modern action games.")
                
            }
        }
        
        
    }
}

#Preview {
    AboutJoaquin()
}
