using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ModelObjet;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Devoir2
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        Dictionary<string, List<ActionAchetee>> dico;
        List<ActionReelle> lesActionsReelles;


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lesActionsReelles = new List<ActionReelle>();
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "AAPL",
                NomAction = "Apple",
                ValeurAction = 200
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "MSFT",
                NomAction = "Microsoft",
                ValeurAction = 14
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "TWTR",
                NomAction = "Twitter",
                ValeurAction = 40
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "IBM",
                NomAction = "International Business Machines",
                ValeurAction = 140
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "FB",
                NomAction = "Facebook",
                ValeurAction = 180
            });

            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "AXA",
                NomAction = "Axa assurances",
                ValeurAction = 25
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "SAP",
                NomAction = "SAP SE",
                ValeurAction = 120
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "INTC",
                NomAction = "Intel Corporation",
                ValeurAction = 50
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "VMW",
                NomAction = "VMware",
                ValeurAction = 145
            }
            );
            lesActionsReelles.Add(new ActionReelle()
            {
                CodeAction = "TXN",
                NomAction = "Texas Instrument Incorporated",
                ValeurAction = 130
            }
            );

            
            dico = new Dictionary<string, List<ActionAchetee>>();
            dico.Add("Enzo", new List<ActionAchetee>()
            {
            new ActionAchetee()
            {
                CodeAction = "AAPL",
                NomAction = "Apple",
                ValeurAction = 200,
                PrixAchat = 210,
                Quantite = 10
            },
            new ActionAchetee()
            {
                CodeAction = "MSFT",
                NomAction = "Microsoft",
                ValeurAction = 140,
                PrixAchat = 100,
                Quantite = 50
            },
            new ActionAchetee()
            {
                CodeAction = "TWTR",
                NomAction = "Twitter",
                ValeurAction = 40,
                PrixAchat = 35,
                Quantite = 20
            },
            new ActionAchetee()
            {
                CodeAction = "IBM",
                NomAction = "International Business Machines",
                ValeurAction = 140,
                PrixAchat = 110,
                Quantite = 40
            }
            });
            dico.Add
            ("Noa", new List<ActionAchetee>()
            {
            new ActionAchetee()
            {
                CodeAction = "FB",
                NomAction = "Facebook",
                ValeurAction = 180,
                PrixAchat = 210,
                Quantite = 10
            },
            new ActionAchetee()
            {
                CodeAction = "AXA",
                NomAction = "Axa assurances",
                ValeurAction = 25,
                PrixAchat = 15,
                Quantite = 20
            },
            new ActionAchetee()
            {
                CodeAction = "SAP",
                NomAction = "SAP SE",
                ValeurAction = 120,
                PrixAchat = 100,
                Quantite = 30
            }
            }
            );
            dico.Add("Lilou", new List<ActionAchetee>()
            {
            new ActionAchetee()
            {
                CodeAction = "TWTR",
                NomAction = "Twitter",
                ValeurAction = 40,
                PrixAchat = 25,
                Quantite = 50
            },
            new ActionAchetee()
            {
                CodeAction = "INTC",
                NomAction = "Intel Corporation",
                ValeurAction = 50,
                PrixAchat = 35,
            },
            new ActionAchetee()
            {
                CodeAction = "VMW",
                ValeurAction = 145,
                PrixAchat = 150,
                Quantite = 30
            },
            new ActionAchetee()
            {
                CodeAction = "TXN",
                NomAction = "Texas Instrument Incorporated",
                ValeurAction = 130,
                PrixAchat = 140,
                Quantite = 25
            }
            }
            );
            lvActions.ItemsSource = null;
            lvActions.ItemsSource = lesActionsReelles;
        }

        private void LvActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvActions.ItemsSource = null;
            lvActions.ItemsSource = lesActionsReelles;
        }

        private void LvTraders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvActions.SelectedItem != null)
            {
                lvActions.ItemsSource = null;
                lvActions.ItemsSource = dico[lvActions.SelectedItem.ToString()];
            }
        }

        private void TxtMontantPortefeuille_TextChanged(object sender, TextChangedEventArgs e)
        {
            double mtTotal = 0;
            foreach(ActionAchetee a in dico[lvActions.ToString()])
            {
                mtTotal = Quantite * PrixAchat;               
            }
            txtMontantPortefeuille = mtTotal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtPrixAchat.Text != null)
            {

            }
        }
    }
}
