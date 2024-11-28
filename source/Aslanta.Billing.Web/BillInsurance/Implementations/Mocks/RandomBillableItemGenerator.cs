using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

internal class RandomBillableItemGenerator
{
    public static BillableItem Generate()
    {
        return _billableItems[RandomInstance.Random.Next(_billableItems.Length)];
    }

    private static BillableItem[] _billableItems = new BillableItem[]
    {
        new BillableItem { Id = 1, Name = "CBC", Type = BillableItemType.Test },
new BillableItem { Id = 2, Name = "Lipid Panel", Type = BillableItemType.Test },
new BillableItem { Id = 3, Name = "Basic Metabolic Panel", Type = BillableItemType.Test },
new BillableItem { Id = 4, Name = "Comprehensive Metabolic Panel", Type = BillableItemType.Test },
new BillableItem { Id = 5, Name = "Thyroid Panel", Type = BillableItemType.Test },
new BillableItem { Id = 6, Name = "Liver Function Test", Type = BillableItemType.Test },
new BillableItem { Id = 7, Name = "Renal Function Panel", Type = BillableItemType.Test },
new BillableItem { Id = 8, Name = "Hemoglobin A1c", Type = BillableItemType.Test },
new BillableItem { Id = 9, Name = "Prothrombin Time (PT)", Type = BillableItemType.Test },
new BillableItem { Id = 10, Name = "Partial Thromboplastin Time (PTT)", Type = BillableItemType.Test },
new BillableItem { Id = 11, Name = "Complete Urinalysis", Type = BillableItemType.Test },
new BillableItem { Id = 12, Name = "Electrolyte Panel", Type = BillableItemType.Test },
new BillableItem { Id = 13, Name = "Vitamin D 25-Hydroxy", Type = BillableItemType.Test },
new BillableItem { Id = 14, Name = "B-Type Natriuretic Peptide (BNP)", Type = BillableItemType.Test },
new BillableItem { Id = 15, Name = "C-Reactive Protein (CRP)", Type = BillableItemType.Test },
new BillableItem { Id = 16, Name = "Ferritin", Type = BillableItemType.Test },
new BillableItem { Id = 17, Name = "Iron Panel", Type = BillableItemType.Test },
new BillableItem { Id = 18, Name = "Folate", Type = BillableItemType.Test },
new BillableItem { Id = 19, Name = "B12 Level", Type = BillableItemType.Test },
new BillableItem { Id = 20, Name = "Blood Culture", Type = BillableItemType.Test },
new BillableItem { Id = 21, Name = "Stool Culture", Type = BillableItemType.Test },
new BillableItem { Id = 22, Name = "Urine Culture", Type = BillableItemType.Test },
new BillableItem { Id = 23, Name = "Sputum Culture", Type = BillableItemType.Test },
new BillableItem { Id = 24, Name = "Rapid Strep Test", Type = BillableItemType.Test },
new BillableItem { Id = 25, Name = "Influenza Test", Type = BillableItemType.Test },
new BillableItem { Id = 26, Name = "COVID-19 PCR", Type = BillableItemType.Test },
new BillableItem { Id = 27, Name = "HIV Test", Type = BillableItemType.Test },
new BillableItem { Id = 28, Name = "Hepatitis B Surface Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 29, Name = "Hepatitis C Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 30, Name = "Syphilis Test", Type = BillableItemType.Test },
new BillableItem { Id = 31, Name = "Rheumatoid Factor", Type = BillableItemType.Test },
new BillableItem { Id = 32, Name = "Antinuclear Antibodies (ANA)", Type = BillableItemType.Test },
new BillableItem { Id = 33, Name = "Uric Acid", Type = BillableItemType.Test },
new BillableItem { Id = 34, Name = "Glucose Tolerance Test", Type = BillableItemType.Test },
new BillableItem { Id = 35, Name = "Lactate Dehydrogenase (LDH)", Type = BillableItemType.Test },
new BillableItem { Id = 36, Name = "Creatinine Kinase", Type = BillableItemType.Test },
new BillableItem { Id = 37, Name = "Troponin", Type = BillableItemType.Test },
new BillableItem { Id = 38, Name = "D-Dimer", Type = BillableItemType.Test },
new BillableItem { Id = 39, Name = "Serum Osmolality", Type = BillableItemType.Test },
new BillableItem { Id = 40, Name = "Amylase", Type = BillableItemType.Test },
new BillableItem { Id = 41, Name = "Lipase", Type = BillableItemType.Test },
new BillableItem { Id = 42, Name = "Parathyroid Hormone", Type = BillableItemType.Test },
new BillableItem { Id = 43, Name = "Cortisol", Type = BillableItemType.Test },
new BillableItem { Id = 44, Name = "Prolactin", Type = BillableItemType.Test },
new BillableItem { Id = 45, Name = "FSH", Type = BillableItemType.Test },
new BillableItem { Id = 46, Name = "LH", Type = BillableItemType.Test },
new BillableItem { Id = 47, Name = "Estradiol", Type = BillableItemType.Test },
new BillableItem { Id = 48, Name = "Progesterone", Type = BillableItemType.Test },
new BillableItem { Id = 49, Name = "Testosterone", Type = BillableItemType.Test },
new BillableItem { Id = 50, Name = "Serum Iron", Type = BillableItemType.Test },
new BillableItem { Id = 51, Name = "TIBC", Type = BillableItemType.Test },
new BillableItem { Id = 52, Name = "Ferritin", Type = BillableItemType.Test },
new BillableItem { Id = 53, Name = "Zinc Level", Type = BillableItemType.Test },
new BillableItem { Id = 54, Name = "Magnesium Level", Type = BillableItemType.Test },
new BillableItem { Id = 55, Name = "Copper Level", Type = BillableItemType.Test },
new BillableItem { Id = 56, Name = "Lead Level", Type = BillableItemType.Test },
new BillableItem { Id = 57, Name = "Mercury Level", Type = BillableItemType.Test },
new BillableItem { Id = 58, Name = "Arsenic Level", Type = BillableItemType.Test },
new BillableItem { Id = 59, Name = "Urine Microalbumin", Type = BillableItemType.Test },
new BillableItem { Id = 60, Name = "Serum Protein Electrophoresis", Type = BillableItemType.Test },
new BillableItem { Id = 61, Name = "Urine Protein Electrophoresis", Type = BillableItemType.Test },
new BillableItem { Id = 62, Name = "Beta-hCG Quantitative", Type = BillableItemType.Test },
new BillableItem { Id = 63, Name = "AFP (Alpha-Fetoprotein)", Type = BillableItemType.Test },
new BillableItem { Id = 64, Name = "CEA (Carcinoembryonic Antigen)", Type = BillableItemType.Test },
new BillableItem { Id = 65, Name = "CA 125", Type = BillableItemType.Test },
new BillableItem { Id = 66, Name = "CA 19-9", Type = BillableItemType.Test },
new BillableItem { Id = 67, Name = "PSA (Prostate-Specific Antigen)", Type = BillableItemType.Test },
new BillableItem { Id = 68, Name = "Pap Smear", Type = BillableItemType.Test },
new BillableItem { Id = 69, Name = "HPV DNA Test", Type = BillableItemType.Test },
new BillableItem { Id = 70, Name = "Chlamydia Test", Type = BillableItemType.Test },
new BillableItem { Id = 71, Name = "Gonorrhea Test", Type = BillableItemType.Test },
new BillableItem { Id = 72, Name = "Trichomonas Test", Type = BillableItemType.Test },
new BillableItem { Id = 73, Name = "Herpes Simplex Virus (HSV) PCR", Type = BillableItemType.Test },
new BillableItem { Id = 74, Name = "Epstein-Barr Virus (EBV) Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 75, Name = "Cytomegalovirus (CMV) Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 76, Name = "Varicella-Zoster Virus Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 77, Name = "Measles Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 78, Name = "Mumps Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 79, Name = "Rubella Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 80, Name = "Toxoplasma Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 81, Name = "Legionella Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 82, Name = "Histoplasma Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 83, Name = "Cryptococcus Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 84, Name = "Coccidioides Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 85, Name = "Aspergillus Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 86, Name = "COVID-19 Antibody Test", Type = BillableItemType.Test },
new BillableItem { Id = 87, Name = "Respiratory Pathogen Panel", Type = BillableItemType.Test },
new BillableItem { Id = 88, Name = "Gastrointestinal Pathogen Panel", Type = BillableItemType.Test },
new BillableItem { Id = 89, Name = "Sexually Transmitted Infections Panel", Type = BillableItemType.Test },
new BillableItem { Id = 90, Name = "Fungal Culture", Type = BillableItemType.Test },
new BillableItem { Id = 91, Name = "Allergen-Specific IgE Test", Type = BillableItemType.Test },
new BillableItem { Id = 92, Name = "Hemoglobin Electrophoresis", Type = BillableItemType.Test },
new BillableItem { Id = 93, Name = "G6PD Deficiency Test", Type = BillableItemType.Test },
new BillableItem { Id = 94, Name = "Sickle Cell Test", Type = BillableItemType.Test },
new BillableItem { Id = 95, Name = "Vitamin B6 Level", Type = BillableItemType.Test },
new BillableItem { Id = 96, Name = "Serum Folate", Type = BillableItemType.Test },
new BillableItem { Id = 97, Name = "Erythrocyte Sedimentation Rate (ESR)", Type = BillableItemType.Test },
new BillableItem { Id = 98, Name = "Prostate Health Index (PHI)", Type = BillableItemType.Test },
new BillableItem { Id = 99, Name = "Anti-Mullerian Hormone (AMH)", Type = BillableItemType.Test },
new BillableItem { Id = 100, Name = "Cardio IQ Lipoprotein (a)", Type = BillableItemType.Test },
new BillableItem { Id = 101, Name = "Adenovirus PCR", Type = BillableItemType.Test },
new BillableItem { Id = 102, Name = "Aldosterone, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 103, Name = "Alpha-1 Antitrypsin", Type = BillableItemType.Test },
new BillableItem { Id = 104, Name = "Ammonia, Plasma", Type = BillableItemType.Test },
new BillableItem { Id = 105, Name = "Anti-Thyroglobulin Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 106, Name = "Anti-Thyroid Peroxidase Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 107, Name = "Aspartate Aminotransferase (AST)", Type = BillableItemType.Test },
new BillableItem { Id = 108, Name = "Autoimmune Hepatitis Panel", Type = BillableItemType.Test },
new BillableItem { Id = 109, Name = "B-Cell Immunophenotyping", Type = BillableItemType.Test },
new BillableItem { Id = 110, Name = "Bilirubin, Direct", Type = BillableItemType.Test },
new BillableItem { Id = 111, Name = "Bilirubin, Total", Type = BillableItemType.Test },
new BillableItem { Id = 112, Name = "Bone Alkaline Phosphatase", Type = BillableItemType.Test },
new BillableItem { Id = 113, Name = "Brucella Antibody Test", Type = BillableItemType.Test },
new BillableItem { Id = 114, Name = "C-Peptide", Type = BillableItemType.Test },
new BillableItem { Id = 115, Name = "Calcium, Ionized", Type = BillableItemType.Test },
new BillableItem { Id = 116, Name = "Cancer Antigen 27.29", Type = BillableItemType.Test },
new BillableItem { Id = 117, Name = "Carbamazepine Level", Type = BillableItemType.Test },
new BillableItem { Id = 118, Name = "Carboxyhemoglobin Level", Type = BillableItemType.Test },
new BillableItem { Id = 119, Name = "Catecholamines, Plasma", Type = BillableItemType.Test },
new BillableItem { Id = 120, Name = "Ceruloplasmin", Type = BillableItemType.Test },
new BillableItem { Id = 121, Name = "Chlamydia Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 122, Name = "Chromogranin A", Type = BillableItemType.Test },
new BillableItem { Id = 123, Name = "Clostridium difficile Toxin PCR", Type = BillableItemType.Test },
new BillableItem { Id = 124, Name = "Complement C3", Type = BillableItemType.Test },
new BillableItem { Id = 125, Name = "Complement C4", Type = BillableItemType.Test },
new BillableItem { Id = 126, Name = "Copper, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 127, Name = "Cortisol, Free (Urine)", Type = BillableItemType.Test },
new BillableItem { Id = 128, Name = "Cryoglobulin Test", Type = BillableItemType.Test },
new BillableItem { Id = 129, Name = "Cystatin C", Type = BillableItemType.Test },
new BillableItem { Id = 130, Name = "DHEA-Sulfate", Type = BillableItemType.Test },
new BillableItem { Id = 131, Name = "Drug Screen, Urine", Type = BillableItemType.Test },
new BillableItem { Id = 132, Name = "EBV Early Antigen IgG", Type = BillableItemType.Test },
new BillableItem { Id = 133, Name = "Elastase, Pancreatic", Type = BillableItemType.Test },
new BillableItem { Id = 134, Name = "Erythropoietin Level", Type = BillableItemType.Test },
new BillableItem { Id = 135, Name = "Estriol, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 136, Name = "Factor V Leiden Mutation", Type = BillableItemType.Test },
new BillableItem { Id = 137, Name = "Fibrinogen Activity", Type = BillableItemType.Test },
new BillableItem { Id = 138, Name = "Free Fatty Acids, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 139, Name = "Free T3 (Triiodothyronine)", Type = BillableItemType.Test },
new BillableItem { Id = 140, Name = "Free T4 (Thyroxine)", Type = BillableItemType.Test },
new BillableItem { Id = 141, Name = "Galactosemia Quantitation", Type = BillableItemType.Test },
new BillableItem { Id = 142, Name = "Gastrin", Type = BillableItemType.Test },
new BillableItem { Id = 143, Name = "Growth Hormone (GH)", Type = BillableItemType.Test },
new BillableItem { Id = 144, Name = "Haptoglobin", Type = BillableItemType.Test },
new BillableItem { Id = 145, Name = "Helicobacter pylori Stool Antigen", Type = BillableItemType.Test },
new BillableItem { Id = 146, Name = "Hepatitis A Total Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 147, Name = "Hepatitis B Core Antibody, Total", Type = BillableItemType.Test },
new BillableItem { Id = 148, Name = "Hepatitis B Surface Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 149, Name = "Hepatitis Delta Virus Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 150, Name = "Herpes Simplex Virus IgG", Type = BillableItemType.Test },
new BillableItem { Id = 151, Name = "Herpes Simplex Virus IgM", Type = BillableItemType.Test },
new BillableItem { Id = 152, Name = "Histamine, Plasma", Type = BillableItemType.Test },
new BillableItem { Id = 153, Name = "HIV-1 RNA Quantitative PCR", Type = BillableItemType.Test },
new BillableItem { Id = 154, Name = "Homocysteine, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 155, Name = "Human Growth Hormone (hGH)", Type = BillableItemType.Test },
new BillableItem { Id = 156, Name = "Human Leukocyte Antigen (HLA) Typing", Type = BillableItemType.Test },
new BillableItem { Id = 157, Name = "IgA Level", Type = BillableItemType.Test },
new BillableItem { Id = 158, Name = "IgE Level", Type = BillableItemType.Test },
new BillableItem { Id = 159, Name = "IgG Level", Type = BillableItemType.Test },
new BillableItem { Id = 160, Name = "IgM Level", Type = BillableItemType.Test },
new BillableItem { Id = 161, Name = "Insulin, Free", Type = BillableItemType.Test },
new BillableItem { Id = 162, Name = "Insulin-Like Growth Factor 1 (IGF-1)", Type = BillableItemType.Test },
new BillableItem { Id = 163, Name = "Iron Saturation", Type = BillableItemType.Test },
new BillableItem { Id = 164, Name = "Kappa Free Light Chains, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 165, Name = "Lambda Free Light Chains, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 166, Name = "Lactate, Plasma", Type = BillableItemType.Test },
new BillableItem { Id = 167, Name = "Leptin, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 168, Name = "Lipase, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 169, Name = "Lipoprotein Electrophoresis", Type = BillableItemType.Test },
new BillableItem { Id = 170, Name = "Lyme Disease Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 171, Name = "Magnesium, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 172, Name = "Methylmalonic Acid, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 173, Name = "Mononucleosis Test", Type = BillableItemType.Test },
new BillableItem { Id = 174, Name = "Mycoplasma Pneumoniae Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 175, Name = "Neuron-Specific Enolase (NSE)", Type = BillableItemType.Test },
new BillableItem { Id = 176, Name = "Norovirus PCR", Type = BillableItemType.Test },
new BillableItem { Id = 177, Name = "Osmolality, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 178, Name = "Parvovirus B19 IgG", Type = BillableItemType.Test },
new BillableItem { Id = 179, Name = "Parvovirus B19 IgM", Type = BillableItemType.Test },
new BillableItem { Id = 180, Name = "Phosphate, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 181, Name = "Phospholipid Antibodies", Type = BillableItemType.Test },
new BillableItem { Id = 182, Name = "Porphyrins, Urine", Type = BillableItemType.Test },
new BillableItem { Id = 183, Name = "Proinsulin", Type = BillableItemType.Test },
new BillableItem { Id = 184, Name = "Protein C Activity", Type = BillableItemType.Test },
new BillableItem { Id = 185, Name = "Protein S Activity", Type = BillableItemType.Test },
new BillableItem { Id = 186, Name = "Prothrombin Mutation Test", Type = BillableItemType.Test },
new BillableItem { Id = 187, Name = "Rabies Antibody Titer", Type = BillableItemType.Test },
new BillableItem { Id = 188, Name = "Renin Activity, Plasma", Type = BillableItemType.Test },
new BillableItem { Id = 189, Name = "Respiratory Syncytial Virus PCR", Type = BillableItemType.Test },
new BillableItem { Id = 190, Name = "Rickettsia Antibody Test", Type = BillableItemType.Test },
new BillableItem { Id = 191, Name = "Salicylate Level", Type = BillableItemType.Test },
new BillableItem { Id = 192, Name = "Schistosoma Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 193, Name = "Sex Hormone Binding Globulin (SHBG)", Type = BillableItemType.Test },
new BillableItem { Id = 194, Name = "Sodium, Serum", Type = BillableItemType.Test },
new BillableItem { Id = 195, Name = "Tacrolimus Level", Type = BillableItemType.Test },
new BillableItem { Id = 196, Name = "Tetanus Antibody", Type = BillableItemType.Test },
new BillableItem { Id = 197, Name = "Thyroglobulin", Type = BillableItemType.Test },
new BillableItem { Id = 198, Name = "Thyroid-Stimulating Immunoglobulin", Type = BillableItemType.Test },
new BillableItem { Id = 199, Name = "Tissue Transglutaminase Antibody, IgA", Type = BillableItemType.Test },
new BillableItem { Id = 200, Name = "Toxoplasma IgG", Type = BillableItemType.Test },
    };
}
