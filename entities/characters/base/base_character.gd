class_name BaseCharacter extends CharacterBody3D

@export var bootstrap_script: Script

@onready var target_point: Marker3D = $Marker/TargetPoint
@onready var ground_target_marker: Decal = $Marker/GroundTargetMarker
@onready var directional_target_marker: DirectionalTargetMarker = $Marker/DirectionalTargetMarker

const HIT_WEAK_COOLDOWN := 0.2
const HIT_STRONG_COOLDOWN := 0.4

var _status_manager: EntityStatusManager
var _processor: EntityProcessor

func _ready() -> void:
	var bootstrapper: BaseCharacterBootstrapper = bootstrap_script.new(self)
	if bootstrapper.has_method("setup"):
		bootstrapper.setup(self)
	
	bootstrapper.boot()

func get_target_point() -> Marker3D:
	return target_point
