using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPFTreeViewSample
{
	/**
		@brief	関節
	*/
	class Joint : ObservableCollection<Joint>
	{
		//----- Property ------------------------------------------------------------
		public string Name { get; private set; }	//!< 名前


		//----- Public Method -------------------------------------------------------
		/**
			@brief	コンストラクタ(初期化)
			@param	[in] i_name	関節の名前
		*/
		public Joint( string i_name )
		{
			Name = i_name;
		}
	}

	/**
		@brief	MainWindowのViewModel
	*/
	class ViewModel
	{
		//----- Property ------------------------------------------------------------
		public ObservableCollection<Joint> JointTree { get; private set; }	//!< 関節リスト

		//----- Public Method -------------------------------------------------------
		/**
			@brief	コンストラクタ(関節リストの作成)
		*/
		public ViewModel()
		{
			JointTree = new ObservableCollection<Joint>();
			Joint root =
				new Joint( "Sacrum" ){
					new Joint( "Hip" ){
						new Joint( "Knee" ){
							new Joint( "angle" ){
								new Joint( "Foot" )
							}
						}
					},
					new Joint( "Spine" ){
						new Joint( "Neck" ){
							new Joint( "Head" ),
							new Joint( "Shoulder" ){
								new Joint("Elbow"){
									new Joint("Hand")
								}
							}
						}
					}
				};

			JointTree.Add( root );
		}
	}
}
