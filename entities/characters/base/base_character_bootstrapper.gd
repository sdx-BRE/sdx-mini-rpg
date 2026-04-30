class_name BaseCharacterBootstrapper extends RefCounted

var _entity: BaseCharacter

func _init(
	entity: BaseCharacter
) -> void:
	_entity = entity

func boot() -> void:
	_boot_stats()

func _boot_stats() -> void:
	var stats := EntityStats.from_enemy_data(_entity.data)
	var debuffs := EntityDebuffs.new()
	_entity._status_manager = EntityStatusManager.new(stats, debuffs, _entity.target_point)

func _boot_processor() -> void:
	_entity._processor = EntityProcessor.new(_entity.get_viewport())

	_entity._processor.add_process_handler(EntityStatusProcessHandler.new(_entity._status_manager))
	_boot_processor_process_handler()

func _boot_processor_process_handler() -> void: pass
